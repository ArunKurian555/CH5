using System;
using System.Collections.Generic;
using System.Linq;
using Crestron.SimplSharpPro.DeviceSupport;
using Crestron.SimplSharpPro;

namespace CBlink
{
    public interface IArea
    {
        object UserObject { get; set; }

        event EventHandler<UIEventArgs> AreaSelect0;
        event EventHandler<UIEventArgs> AreaSelect1;
        event EventHandler<UIEventArgs> AreaSelect2;
        event EventHandler<UIEventArgs> AreaSelect3;
        event EventHandler<UIEventArgs> AreaSelect4;
        event EventHandler<UIEventArgs> AreaSelect5;
        event EventHandler<UIEventArgs> AreaSelect6;
        event EventHandler<UIEventArgs> AreaSelect7;
        event EventHandler<UIEventArgs> AreaSelect8;
        event EventHandler<UIEventArgs> AreaSelect9;
        event EventHandler<UIEventArgs> AreaSelect10;

        void AreaSelected0(AreaBoolInputSigDelegate callback);
        void AreaSelected1(AreaBoolInputSigDelegate callback);
        void AreaSelected2(AreaBoolInputSigDelegate callback);
        void AreaSelected3(AreaBoolInputSigDelegate callback);
        void AreaSelected4(AreaBoolInputSigDelegate callback);
        void AreaSelected5(AreaBoolInputSigDelegate callback);
        void AreaSelected6(AreaBoolInputSigDelegate callback);
        void AreaSelected7(AreaBoolInputSigDelegate callback);
        void AreaSelected8(AreaBoolInputSigDelegate callback);
        void AreaSelected9(AreaBoolInputSigDelegate callback);
        void AreaSelected10(AreaBoolInputSigDelegate callback);
        void Size(AreaUShortInputSigDelegate callback);
        void ActiveArea(AreaStringInputSigDelegate callback);
        void AreaName0(AreaStringInputSigDelegate callback);
        void AreaName1(AreaStringInputSigDelegate callback);
        void AreaName2(AreaStringInputSigDelegate callback);
        void AreaName3(AreaStringInputSigDelegate callback);
        void AreaName4(AreaStringInputSigDelegate callback);
        void AreaName5(AreaStringInputSigDelegate callback);
        void AreaName6(AreaStringInputSigDelegate callback);
        void AreaName7(AreaStringInputSigDelegate callback);
        void AreaName8(AreaStringInputSigDelegate callback);
        void AreaName9(AreaStringInputSigDelegate callback);
        void AreaName10(AreaStringInputSigDelegate callback);

    }

    public delegate void AreaBoolInputSigDelegate(BoolInputSig boolInputSig, IArea area);
    public delegate void AreaUShortInputSigDelegate(UShortInputSig uShortInputSig, IArea area);
    public delegate void AreaStringInputSigDelegate(StringInputSig stringInputSig, IArea area);

    internal class Area : IArea, IDisposable
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
                public const uint AreaSelect0 = 1;
                public const uint AreaSelect1 = 2;
                public const uint AreaSelect2 = 3;
                public const uint AreaSelect3 = 4;
                public const uint AreaSelect4 = 5;
                public const uint AreaSelect5 = 6;
                public const uint AreaSelect6 = 7;
                public const uint AreaSelect7 = 8;
                public const uint AreaSelect8 = 9;
                public const uint AreaSelect9 = 10;
                public const uint AreaSelect10 = 11;

                public const uint AreaSelected0 = 1;
                public const uint AreaSelected1 = 2;
                public const uint AreaSelected2 = 3;
                public const uint AreaSelected3 = 4;
                public const uint AreaSelected4 = 5;
                public const uint AreaSelected5 = 6;
                public const uint AreaSelected6 = 7;
                public const uint AreaSelected7 = 8;
                public const uint AreaSelected8 = 9;
                public const uint AreaSelected9 = 10;
                public const uint AreaSelected10 = 11;
            }
            internal static class Numerics
            {

                public const uint Size = 1;
            }
            internal static class Strings
            {

                public const uint ActiveArea = 1;
                public const uint AreaName0 = 2;
                public const uint AreaName1 = 3;
                public const uint AreaName2 = 4;
                public const uint AreaName3 = 5;
                public const uint AreaName4 = 6;
                public const uint AreaName5 = 7;
                public const uint AreaName6 = 8;
                public const uint AreaName7 = 9;
                public const uint AreaName8 = 10;
                public const uint AreaName9 = 11;
                public const uint AreaName10 = 12;
            }
        }

        #endregion

        #region Construction and Initialization

        internal Area(ComponentMediator componentMediator, uint controlJoinId)
        {
            ComponentMediator = componentMediator;
            Initialize(controlJoinId);
        }

        private void Initialize(uint controlJoinId)
        {
            ControlJoinId = controlJoinId; 
 
            _devices = new List<BasicTriListWithSmartObject>(); 
 
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect0, onAreaSelect0);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect1, onAreaSelect1);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect2, onAreaSelect2);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect3, onAreaSelect3);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect4, onAreaSelect4);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect5, onAreaSelect5);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect6, onAreaSelect6);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect7, onAreaSelect7);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect8, onAreaSelect8);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect9, onAreaSelect9);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.AreaSelect10, onAreaSelect10);

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

        public event EventHandler<UIEventArgs> AreaSelect0;
        private void onAreaSelect0(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect0;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect1;
        private void onAreaSelect1(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect1;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect2;
        private void onAreaSelect2(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect2;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect3;
        private void onAreaSelect3(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect3;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect4;
        private void onAreaSelect4(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect4;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect5;
        private void onAreaSelect5(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect5;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect6;
        private void onAreaSelect6(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect6;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect7;
        private void onAreaSelect7(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect7;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect8;
        private void onAreaSelect8(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect8;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect9;
        private void onAreaSelect9(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect9;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> AreaSelect10;
        private void onAreaSelect10(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = AreaSelect10;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }


        public void AreaSelected0(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected0], this);
            }
        }

        public void AreaSelected1(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected1], this);
            }
        }

        public void AreaSelected2(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected2], this);
            }
        }

        public void AreaSelected3(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected3], this);
            }
        }

        public void AreaSelected4(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected4], this);
            }
        }

        public void AreaSelected5(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected5], this);
            }
        }

        public void AreaSelected6(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected6], this);
            }
        }

        public void AreaSelected7(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected7], this);
            }
        }

        public void AreaSelected8(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected8], this);
            }
        }

        public void AreaSelected9(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected9], this);
            }
        }

        public void AreaSelected10(AreaBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.AreaSelected10], this);
            }
        }


        public void Size(AreaUShortInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].UShortInput[Joins.Numerics.Size], this);
            }
        }


        public void ActiveArea(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.ActiveArea], this);
            }
        }

        public void AreaName0(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName0], this);
            }
        }

        public void AreaName1(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName1], this);
            }
        }

        public void AreaName2(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName2], this);
            }
        }

        public void AreaName3(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName3], this);
            }
        }

        public void AreaName4(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName4], this);
            }
        }

        public void AreaName5(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName5], this);
            }
        }

        public void AreaName6(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName6], this);
            }
        }

        public void AreaName7(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName7], this);
            }
        }

        public void AreaName8(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName8], this);
            }
        }

        public void AreaName9(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName9], this);
            }
        }

        public void AreaName10(AreaStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.AreaName10], this);
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
            return string.Format("Contract: {0} Component: {1} HashCode: {2} {3}", "Area", GetType().Name, GetHashCode(), UserObject != null ? "UserObject: " + UserObject : null);
        }

        #endregion

        #region IDisposable

        public bool IsDisposed { get; set; }

        public void Dispose()
        {
            if (IsDisposed)
                return;

            IsDisposed = true;

            AreaSelect0 = null;
            AreaSelect1 = null;
            AreaSelect2 = null;
            AreaSelect3 = null;
            AreaSelect4 = null;
            AreaSelect5 = null;
            AreaSelect6 = null;
            AreaSelect7 = null;
            AreaSelect8 = null;
            AreaSelect9 = null;
            AreaSelect10 = null;
        }

        #endregion

    }
}
