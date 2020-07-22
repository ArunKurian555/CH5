using System;
using System.Collections.Generic;
using System.Linq;
using Crestron.SimplSharpPro.DeviceSupport;
using Crestron.SimplSharpPro;

namespace CBlink
{
    public interface ISch
    {
        object UserObject { get; set; }

        event EventHandler<UIEventArgs> ET0;
        event EventHandler<UIEventArgs> ET1;
        event EventHandler<UIEventArgs> ET2;
        event EventHandler<UIEventArgs> ET3;
        event EventHandler<UIEventArgs> ET4;
        event EventHandler<UIEventArgs> ET5;
        event EventHandler<UIEventArgs> ET6;
        event EventHandler<UIEventArgs> ET7;
        event EventHandler<UIEventArgs> ET8;
        event EventHandler<UIEventArgs> ET9;
        event EventHandler<UIEventArgs> ET10;

        void ETF0(SchBoolInputSigDelegate callback);
        void ETF1(SchBoolInputSigDelegate callback);
        void ETF2(SchBoolInputSigDelegate callback);
        void ETF3(SchBoolInputSigDelegate callback);
        void ETF4(SchBoolInputSigDelegate callback);
        void ETF5(SchBoolInputSigDelegate callback);
        void ETF6(SchBoolInputSigDelegate callback);
        void ETF7(SchBoolInputSigDelegate callback);
        void ETF8(SchBoolInputSigDelegate callback);
        void ETF9(SchBoolInputSigDelegate callback);
        void ETF10(SchBoolInputSigDelegate callback);
        void EN0(SchStringInputSigDelegate callback);
        void EN1(SchStringInputSigDelegate callback);
        void EN2(SchStringInputSigDelegate callback);
        void EN3(SchStringInputSigDelegate callback);
        void EN4(SchStringInputSigDelegate callback);
        void EN5(SchStringInputSigDelegate callback);
        void EN6(SchStringInputSigDelegate callback);
        void EN7(SchStringInputSigDelegate callback);
        void EN8(SchStringInputSigDelegate callback);
        void EN9(SchStringInputSigDelegate callback);
        void EN10(SchStringInputSigDelegate callback);

    }

    public delegate void SchBoolInputSigDelegate(BoolInputSig boolInputSig, ISch sch);
    public delegate void SchStringInputSigDelegate(StringInputSig stringInputSig, ISch sch);

    internal class Sch : ISch, IDisposable
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
                public const uint ET0 = 1;
                public const uint ET1 = 2;
                public const uint ET2 = 3;
                public const uint ET3 = 4;
                public const uint ET4 = 5;
                public const uint ET5 = 6;
                public const uint ET6 = 7;
                public const uint ET7 = 8;
                public const uint ET8 = 9;
                public const uint ET9 = 10;
                public const uint ET10 = 11;

                public const uint ETF0 = 1;
                public const uint ETF1 = 2;
                public const uint ETF2 = 3;
                public const uint ETF3 = 4;
                public const uint ETF4 = 5;
                public const uint ETF5 = 6;
                public const uint ETF6 = 7;
                public const uint ETF7 = 8;
                public const uint ETF8 = 9;
                public const uint ETF9 = 10;
                public const uint ETF10 = 11;
            }
            internal static class Strings
            {
                public const uint EN0 = 1;
                public const uint EN1 = 2;
                public const uint EN2 = 3;
                public const uint EN3 = 4;
                public const uint EN4 = 5;
                public const uint EN5 = 6;
                public const uint EN6 = 7;
                public const uint EN7 = 8;
                public const uint EN8 = 9;
                public const uint EN9 = 10;
                public const uint EN10 = 11;
            }
        }

        #endregion

        #region Construction and Initialization

        internal Sch(ComponentMediator componentMediator, uint controlJoinId)
        {
            ComponentMediator = componentMediator;
            Initialize(controlJoinId);
        }

        private void Initialize(uint controlJoinId)
        {
            ControlJoinId = controlJoinId; 
 
            _devices = new List<BasicTriListWithSmartObject>(); 
 
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.ET0, onET0);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.ET1, onET1);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.ET2, onET2);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.ET3, onET3);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.ET4, onET4);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.ET5, onET5);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.ET6, onET6);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.ET7, onET7);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.ET8, onET8);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.ET9, onET9);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.ET10, onET10);

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

        public event EventHandler<UIEventArgs> ET0;
        private void onET0(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = ET0;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> ET1;
        private void onET1(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = ET1;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> ET2;
        private void onET2(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = ET2;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> ET3;
        private void onET3(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = ET3;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> ET4;
        private void onET4(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = ET4;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> ET5;
        private void onET5(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = ET5;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> ET6;
        private void onET6(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = ET6;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> ET7;
        private void onET7(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = ET7;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> ET8;
        private void onET8(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = ET8;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> ET9;
        private void onET9(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = ET9;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> ET10;
        private void onET10(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = ET10;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }


        public void ETF0(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.ETF0], this);
            }
        }

        public void ETF1(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.ETF1], this);
            }
        }

        public void ETF2(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.ETF2], this);
            }
        }

        public void ETF3(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.ETF3], this);
            }
        }

        public void ETF4(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.ETF4], this);
            }
        }

        public void ETF5(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.ETF5], this);
            }
        }

        public void ETF6(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.ETF6], this);
            }
        }

        public void ETF7(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.ETF7], this);
            }
        }

        public void ETF8(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.ETF8], this);
            }
        }

        public void ETF9(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.ETF9], this);
            }
        }

        public void ETF10(SchBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.ETF10], this);
            }
        }

        public void EN0(SchStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.EN0], this);
            }
        }

        public void EN1(SchStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.EN1], this);
            }
        }

        public void EN2(SchStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.EN2], this);
            }
        }

        public void EN3(SchStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.EN3], this);
            }
        }

        public void EN4(SchStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.EN4], this);
            }
        }

        public void EN5(SchStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.EN5], this);
            }
        }

        public void EN6(SchStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.EN6], this);
            }
        }

        public void EN7(SchStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.EN7], this);
            }
        }

        public void EN8(SchStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.EN8], this);
            }
        }

        public void EN9(SchStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.EN9], this);
            }
        }

        public void EN10(SchStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.EN10], this);
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
            return string.Format("Contract: {0} Component: {1} HashCode: {2} {3}", "Sch", GetType().Name, GetHashCode(), UserObject != null ? "UserObject: " + UserObject : null);
        }

        #endregion

        #region IDisposable

        public bool IsDisposed { get; set; }

        public void Dispose()
        {
            if (IsDisposed)
                return;

            IsDisposed = true;

            ET0 = null;
            ET1 = null;
            ET2 = null;
            ET3 = null;
            ET4 = null;
            ET5 = null;
            ET6 = null;
            ET7 = null;
            ET8 = null;
            ET9 = null;
            ET10 = null;
        }

        #endregion

    }
}
