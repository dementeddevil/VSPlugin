﻿using System;
using System.Windows.Media;
using BlackBerry.NativeCore.Components;
using BlackBerry.NativeCore.Model;

namespace BlackBerry.Package.ToolWindows.ViewModel
{
    public sealed class TargetViewItem : BaseViewItem
    {
        public TargetViewItem(DeviceDefinition device)
        {
            if (device == null)
                throw new ArgumentNullException("device");

            Device = device;
            AddExpandablePlaceholder();
        }

        #region Properties

        public DeviceDefinition Device
        {
            get;
            private set;
        }

        public override string Name
        {
            get { return Device.ShortName; }
        }

        public override ImageSource ImageSource
        {
            get { return null; }
        }

        #endregion

        #region Overrides

        protected override BaseViewItem CreateProgressPlaceholder()
        {
            return new ProgressViewItem("Connecting...");
        }

        protected override void LoadItems()
        {
            // try to connect to the device (handler will be called at least once, even if connected):
            Targets.Connect(Device, OnDeviceStatusChanged);
        }

        private void OnDeviceStatusChanged(object sender, TargetConnectionEventArgs e)
        {
            BaseViewItem[] items;

            switch(e.Status)
            {
                case TargetStatus.Connecting:
                    items = new BaseViewItem[]
                        {
                            CreateProgressPlaceholder()
                        };
                    break;
                case TargetStatus.Connected:
                    items = new BaseViewItem[]
                        {
                            new ProcessListViewItem(e.Client.SysInfoService),
                            new FileSystemViewItem("Sandboxes", e.Client.FileService, "/accounts/1000/appdata", file => !file.NoAccess),
                            new FileSystemViewItem("Shared", e.Client.FileService, "/accounts/1000/shared", null),
                            new FileSystemViewItem("Developer", e.Client.FileService, "/accounts/devuser", null), 
                            new FileSystemViewItem("System", e.Client.FileService, null, null)
                        };
                    break;
                case TargetStatus.Disconnected:
                    items = new BaseViewItem[0];
                    Collapse();
                    break;
                case TargetStatus.Failed:
                    items = new BaseViewItem[]
                        {
                            new MessageViewItem(e.Message)
                        };
                    break;
                default:
                    items = new BaseViewItem[]
                        {
                            new MessageViewItem(string.Concat("Unsupported device state (", e.Status, ")"))
                        };
                    break;
            }

            OnItemsLoaded(items);
        }

        #endregion
    }
}
