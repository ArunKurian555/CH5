using System;
using System.Collections.Generic;
using System.Linq;
using Crestron.SimplSharpPro.DeviceSupport;
using Crestron.SimplSharpPro;

namespace CBlink
{
    public interface IScenes
    {
        object UserObject { get; set; }

        event EventHandler<UIEventArgs> Scenes0;
        event EventHandler<UIEventArgs> Scenes1;
        event EventHandler<UIEventArgs> Scenes2;
        event EventHandler<UIEventArgs> Scenes3;
        event EventHandler<UIEventArgs> Scenes4;
        event EventHandler<UIEventArgs> Scenes5;
        event EventHandler<UIEventArgs> Scenes6;
        event EventHandler<UIEventArgs> Scenes7;

        void ScenesName0(ScenesStringInputSigDelegate callback);
        void ScenesName1(ScenesStringInputSigDelegate callback);
        void ScenesName2(ScenesStringInputSigDelegate callback);
        void ScenesName3(ScenesStringInputSigDelegate callback);
        void ScenesName4(ScenesStringInputSigDelegate callback);
        void ScenesName5(ScenesStringInputSigDelegate callback);
        void ScenesName6(ScenesStringInputSigDelegate callback);
        void ScenesName7(ScenesStringInputSigDelegate callback);

    }

    public delegate void ScenesBoolInputSigDelegate(BoolInputSig boolInputSig, IScenes scenes);
    public delegate void ScenesStringInputSigDelegate(StringInputSig stringInputSig, IScenes scenes);

    internal class Scenes : IScenes, IDisposable
    {
        #region Standard CH5 Component members

        private ComponentMediator ComponentMediator { get; set; }

        public object UserObject { get; set; }

        public uint ControlJoinId { get; private set; }

        private IList<BasicTriListWithSmartObject> _devices;
        public IList<BasicTriListWithSmartObject> Devices { get { return _devices; } }

        #endregion

        #region Joins

        private static class Joins
        {
            internal static class Booleans
            {
                public const uint Scenes0 = 1;
                public const uint Scenes1 = 2;
                public const uint Scenes2 = 3;
                public const uint Scenes3 = 4;
                public const uint Scenes4 = 5;
                public const uint Scenes5 = 6;
                public const uint Scenes6 = 7;
                public const uint Scenes7 = 8;

            }
            internal static class Strings
            {
                public const uint ScenesName0 = 1;
                public const uint ScenesName1 = 2;
                public const uint ScenesName2 = 3;
                public const uint ScenesName3 = 4;
                public const uint ScenesName4 = 5;
                public const uint ScenesName5 = 6;
                public const uint ScenesName6 = 7;
                public const uint ScenesName7 = 8;
            }
        }

        #endregion

        #region Construction and Initialization

        internal Scenes(ComponentMediator componentMediator, uint controlJoinId)
        {
            ComponentMediator = componentMediator;
            Initialize(controlJoinId);
        }

        private void Initialize(uint controlJoinId)
        {
            ControlJoinId = controlJoinId; 
 
            _devices = new List<BasicTriListWithSmartObject>(); 
 
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Scenes0, onScenes0);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Scenes1, onScenes1);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Scenes2, onScenes2);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Scenes3, onScenes3);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Scenes4, onScenes4);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Scenes5, onScenes5);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Scenes6, onScenes6);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Scenes7, onScenes7);

        }

        public void AddDevice(BasicTriListWithSmartObject device)
        {
            Devices.Add(device);
            ComponentMediator.HookSmartObjectEvents(device.SmartObjects[ControlJoinId]);
        }

        public void RemoveDevice(BasicTriListWithSmartObject device)
        {
            Devices.Remove(device);
            ComponentMediator.UnHookSmartObjectEvents(device.SmartObjects[ControlJoinId]);
        }

        #endregion

        #region CH5 Contract

        public event EventHandler<UIEventArgs> Scenes0;
        private void onScenes0(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Scenes0;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Scenes1;
        private void onScenes1(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Scenes1;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Scenes2;
        private void onScenes2(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Scenes2;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Scenes3;
        private void onScenes3(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Scenes3;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Scenes4;
        private void onScenes4(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Scenes4;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Scenes5;
        private void onScenes5(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Scenes5;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Scenes6;
        private void onScenes6(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Scenes6;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Scenes7;
        private void onScenes7(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Scenes7;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }


        public void ScenesName0(ScenesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.ScenesName0], this);
            }
        }

        public void ScenesName1(ScenesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.ScenesName1], this);
            }
        }

        public void ScenesName2(ScenesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.ScenesName2], this);
            }
        }

        public void ScenesName3(ScenesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.ScenesName3], this);
            }
        }

        public void ScenesName4(ScenesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.ScenesName4], this);
            }
        }

        public void ScenesName5(ScenesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.ScenesName5], this);
            }
        }

        public void ScenesName6(ScenesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.ScenesName6], this);
            }
        }

        public void ScenesName7(ScenesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.ScenesName7], this);
            }
        }

        #endregion

        #region Overrides

        public override int GetHashCode()
        {
            return (int)ControlJoinId;
        }

        public override string ToString()
        {
            return string.Format("Contract: {0} Component: {1} HashCode: {2} {3}", "Scenes", GetType().Name, GetHashCode(), UserObject != null ? "UserObject: " + UserObject : null);
        }

        #endregion

        #region IDisposable

        public bool IsDisposed { get; set; }

        public void Dispose()
        {
            if (IsDisposed)
                return;

            IsDisposed = true;

            Scenes0 = null;
            Scenes1 = null;
            Scenes2 = null;
            Scenes3 = null;
            Scenes4 = null;
            Scenes5 = null;
            Scenes6 = null;
            Scenes7 = null;
        }

        #endregion

    }
}
