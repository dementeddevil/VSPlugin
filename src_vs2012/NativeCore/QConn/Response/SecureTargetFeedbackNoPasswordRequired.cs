﻿namespace BlackBerry.NativeCore.QConn.Response
{
    sealed class SecureTargetFeedbackNoPasswordRequired : SecureTargetFeedback
    {
        /// <summary>
        /// Init constructor.
        /// </summary>
        public SecureTargetFeedbackNoPasswordRequired(byte[] data, ushort version, ushort code, ushort feedbackCode)
            : base(data, version, code, feedbackCode)
        {
        }
    }
}
