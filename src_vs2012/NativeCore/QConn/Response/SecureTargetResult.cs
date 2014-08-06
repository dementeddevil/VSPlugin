﻿using System;
using System.Text;
using BlackBerry.NativeCore.Diagnostics;
using BlackBerry.NativeCore.Helpers;

namespace BlackBerry.NativeCore.QConn.Response
{
    /// <summary>
    /// Base class for all results received from QConnDoor service on the target.
    /// </summary>
    class SecureTargetResult
    {
        /// <summary>
        /// Init constructor.
        /// </summary>
        public SecureTargetResult(byte[] data, HResult status)
        {
            if (data == null)
                throw new ArgumentNullException("data");

            Data = data;
            Status = status;
        }

        #region Properties

        public byte[] Data
        {
            get;
            private set;
        }

        public HResult Status
        {
            get;
            private set;
        }

        #endregion

        /// <summary>
        /// Loads response from specified array of bytes.
        /// </summary>
        public static SecureTargetResult Load(byte[] result, HResult status)
        {
            if (status != HResult.OK)
                return new SecureTargetResult(result, status);
            if (result == null || result.Length < 6)
            {
                QTraceLog.WriteLine("Packet length was too small: " + (result != null ? result.Length : 0));
                return new SecureTargetResult(result, HResult.InvalidData);
            }

            try
            {
                ushort version = BitHelper.GetUInt16(result, 2);
                ushort code = BitHelper.GetUInt16(result, 4);

                // verify response code:
                switch (code)
                {
                    case 2:
                        ushort feedbackCode = BitHelper.GetUInt16(result, 6);
                        ushort feedbackLength = BitHelper.GetUInt16(result, 8);
                        switch (feedbackCode)
                        {
                            case 0:
                                return new SecureTargetFeedbackOK(result, version, code, feedbackCode);
                            case 10:
                                var message = GetString(result, 10, feedbackLength);
                                return new SecureTargetFeedbackMismatchedVersion(result, version, code, feedbackCode, message);
                            case 21:
                                return new SecureTargetFeedbackNoPasswordRequired(result, version, code, feedbackCode);
                            default:
                                var reason = GetString(result, 10, feedbackLength);
                                return new SecureTargetFeedbackRejected(result, version, code, feedbackCode, reason);

                        }
                    default:
                        QTraceLog.WriteLine("Invalid code received in target response: " + code);
                        return new SecureTargetResponse(result, HResult.InvalidFrameCode, version, code);
                }
            }
            catch (Exception ex)
            {
                QTraceLog.WriteException(ex, "Impossible to interpret response data");
            }
            return new SecureTargetResult(result, HResult.InvalidData);
        }

        private static string GetString(byte[] data, int at, int length)
        {
            return Encoding.UTF8.GetString(data, at, length > 0 ? length - 1 : 0);
        }
    }
}
