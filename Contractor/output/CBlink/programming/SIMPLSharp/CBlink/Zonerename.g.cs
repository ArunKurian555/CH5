using System;
using System.Collections.Generic;
using System.Linq;
using Crestron.SimplSharpPro.DeviceSupport;
using Crestron.SimplSharpPro;

namespace CBlink
{
    public interface IZonerename
    {
        object UserObject { get; set; }

        event EventHandler<UIEventArgs> Zoneflag1;
        event EventHandler<UIEventArgs> Zoneflag2;
        event EventHandler<UIEventArgs> Zoneflag3;
        event EventHandler<UIEventArgs> Zoneflag4;
        event EventHandler<UIEventArgs> Zoneflag5;
        event EventHandler<UIEventArgs> Zoneflag6;
        event EventHandler<UIEventArgs> Zoneflag7;
        event EventHandler<UIEventArgs> Zoneflag8;
        event EventHandler<UIEventArgs> Zoneflag9;
        event EventHandler<UIEventArgs> Zoneflag10;
        event EventHandler<UIEventArgs> Zoneflag11;
        event EventHandler<UIEventArgs> Zoneflag12;
        event EventHandler<UIEventArgs> Zoneflag13;
        event EventHandler<UIEventArgs> Zoneflag14;
        event EventHandler<UIEventArgs> Zoneflag15;
        event EventHandler<UIEventArgs> Zoneflag16;
        event EventHandler<UIEventArgs> Zoneflag17;
        event EventHandler<UIEventArgs> Zoneflag18;
        event EventHandler<UIEventArgs> Zoneflag19;
        event EventHandler<UIEventArgs> Zoneflag20;
        event EventHandler<UIEventArgs> Zoneflag21;
        event EventHandler<UIEventArgs> Zoneflag22;
        event EventHandler<UIEventArgs> Zoneflag23;
        event EventHandler<UIEventArgs> Zoneflag24;
        event EventHandler<UIEventArgs> Zoneflag25;
        event EventHandler<UIEventArgs> Zoneflag26;
        event EventHandler<UIEventArgs> Zoneflag27;
        event EventHandler<UIEventArgs> Zoneflag28;
        event EventHandler<UIEventArgs> Zoneflag29;
        event EventHandler<UIEventArgs> Zoneflag30;
        event EventHandler<UIEventArgs> Zoneflag31;
        event EventHandler<UIEventArgs> Zoneflag32;
        event EventHandler<UIEventArgs> Zoneflag33;
        event EventHandler<UIEventArgs> Zoneflag34;
        event EventHandler<UIEventArgs> Zoneflag35;
        event EventHandler<UIEventArgs> Zoneflag36;
        event EventHandler<UIEventArgs> Zoneflag37;
        event EventHandler<UIEventArgs> Zoneflag38;
        event EventHandler<UIEventArgs> Zoneflag39;
        event EventHandler<UIEventArgs> Zoneflag40;
        event EventHandler<UIEventArgs> Zoneflag41;
        event EventHandler<UIEventArgs> Zoneflag42;
        event EventHandler<UIEventArgs> Zoneflag43;
        event EventHandler<UIEventArgs> Zoneflag44;
        event EventHandler<UIEventArgs> Zoneflag45;
        event EventHandler<UIEventArgs> Zoneflag46;
        event EventHandler<UIEventArgs> Zoneflag47;
        event EventHandler<UIEventArgs> Zoneflag48;
        event EventHandler<UIEventArgs> Zoneflag49;
        event EventHandler<UIEventArgs> Zoneflag50;
        event EventHandler<UIEventArgs> Zoneflag51;
        event EventHandler<UIEventArgs> Zoneflag52;
        event EventHandler<UIEventArgs> Zoneflag53;
        event EventHandler<UIEventArgs> Zoneflag54;
        event EventHandler<UIEventArgs> Zoneflag55;
        event EventHandler<UIEventArgs> Zoneflag56;
        event EventHandler<UIEventArgs> Zoneflag57;
        event EventHandler<UIEventArgs> Zoneflag58;
        event EventHandler<UIEventArgs> Zoneflag59;
        event EventHandler<UIEventArgs> Zoneflag60;
        event EventHandler<UIEventArgs> Zoneflag61;
        event EventHandler<UIEventArgs> Zoneflag62;
        event EventHandler<UIEventArgs> Zoneflag63;
        event EventHandler<UIEventArgs> Zoneflag64;
        event EventHandler<UIEventArgs> Zoneflag65;
        event EventHandler<UIEventArgs> Zoneflag66;
        event EventHandler<UIEventArgs> Zoneflag67;
        event EventHandler<UIEventArgs> Zoneflag68;
        event EventHandler<UIEventArgs> Zoneflag69;
        event EventHandler<UIEventArgs> Zoneflag70;
        event EventHandler<UIEventArgs> Zoneflag71;
        event EventHandler<UIEventArgs> Zoneflag72;
        event EventHandler<UIEventArgs> Zoneflag73;
        event EventHandler<UIEventArgs> Zoneflag74;
        event EventHandler<UIEventArgs> Zoneflag75;
        event EventHandler<UIEventArgs> Zoneflag76;
        event EventHandler<UIEventArgs> Zoneflag77;
        event EventHandler<UIEventArgs> Zoneflag78;
        event EventHandler<UIEventArgs> Zoneflag79;
        event EventHandler<UIEventArgs> Zoneflag80;
        event EventHandler<UIEventArgs> Zoneflag81;
        event EventHandler<UIEventArgs> Zoneflag82;
        event EventHandler<UIEventArgs> Zoneflag83;
        event EventHandler<UIEventArgs> Zoneflag84;
        event EventHandler<UIEventArgs> Zoneflag85;
        event EventHandler<UIEventArgs> Zoneflag86;
        event EventHandler<UIEventArgs> Zoneflag87;
        event EventHandler<UIEventArgs> Zoneflag88;
        event EventHandler<UIEventArgs> Zoneflag89;
        event EventHandler<UIEventArgs> Zoneflag90;
        event EventHandler<UIEventArgs> Zoneflag91;
        event EventHandler<UIEventArgs> Zoneflag92;
        event EventHandler<UIEventArgs> Zoneflag93;
        event EventHandler<UIEventArgs> Zoneflag94;
        event EventHandler<UIEventArgs> Zoneflag95;
        event EventHandler<UIEventArgs> Zoneflag96;
        event EventHandler<UIEventArgs> Zoneflag97;
        event EventHandler<UIEventArgs> Zoneflag98;
        event EventHandler<UIEventArgs> Zoneflag99;
        event EventHandler<UIEventArgs> Zoneflag100;
        event EventHandler<UIEventArgs> Zoneflag101;
        event EventHandler<UIEventArgs> Zoneflag102;
        event EventHandler<UIEventArgs> Zoneflag103;
        event EventHandler<UIEventArgs> Zoneflag104;
        event EventHandler<UIEventArgs> Zoneflag105;
        event EventHandler<UIEventArgs> Zoneflag106;
        event EventHandler<UIEventArgs> Zoneflag107;
        event EventHandler<UIEventArgs> Zoneflag108;
        event EventHandler<UIEventArgs> Zoneflag109;
        event EventHandler<UIEventArgs> Zoneflag110;
        event EventHandler<UIEventArgs> Zoneflag111;
        event EventHandler<UIEventArgs> Zoneflag112;
        event EventHandler<UIEventArgs> Zoneflag113;
        event EventHandler<UIEventArgs> Zoneflag114;
        event EventHandler<UIEventArgs> Zoneflag115;
        event EventHandler<UIEventArgs> Zoneflag116;
        event EventHandler<UIEventArgs> Zoneflag117;
        event EventHandler<UIEventArgs> Zoneflag118;
        event EventHandler<UIEventArgs> Zoneflag119;
        event EventHandler<UIEventArgs> Zoneflag120;


    }

    public delegate void ZonerenameBoolInputSigDelegate(BoolInputSig boolInputSig, IZonerename zonerename);

    internal class Zonerename : IZonerename, IDisposable
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
                public const uint Zoneflag1 = 1;
                public const uint Zoneflag2 = 2;
                public const uint Zoneflag3 = 3;
                public const uint Zoneflag4 = 4;
                public const uint Zoneflag5 = 5;
                public const uint Zoneflag6 = 6;
                public const uint Zoneflag7 = 7;
                public const uint Zoneflag8 = 8;
                public const uint Zoneflag9 = 9;
                public const uint Zoneflag10 = 10;
                public const uint Zoneflag11 = 11;
                public const uint Zoneflag12 = 12;
                public const uint Zoneflag13 = 13;
                public const uint Zoneflag14 = 14;
                public const uint Zoneflag15 = 15;
                public const uint Zoneflag16 = 16;
                public const uint Zoneflag17 = 17;
                public const uint Zoneflag18 = 18;
                public const uint Zoneflag19 = 19;
                public const uint Zoneflag20 = 20;
                public const uint Zoneflag21 = 21;
                public const uint Zoneflag22 = 22;
                public const uint Zoneflag23 = 23;
                public const uint Zoneflag24 = 24;
                public const uint Zoneflag25 = 25;
                public const uint Zoneflag26 = 26;
                public const uint Zoneflag27 = 27;
                public const uint Zoneflag28 = 28;
                public const uint Zoneflag29 = 29;
                public const uint Zoneflag30 = 30;
                public const uint Zoneflag31 = 31;
                public const uint Zoneflag32 = 32;
                public const uint Zoneflag33 = 33;
                public const uint Zoneflag34 = 34;
                public const uint Zoneflag35 = 35;
                public const uint Zoneflag36 = 36;
                public const uint Zoneflag37 = 37;
                public const uint Zoneflag38 = 38;
                public const uint Zoneflag39 = 39;
                public const uint Zoneflag40 = 40;
                public const uint Zoneflag41 = 41;
                public const uint Zoneflag42 = 42;
                public const uint Zoneflag43 = 43;
                public const uint Zoneflag44 = 44;
                public const uint Zoneflag45 = 45;
                public const uint Zoneflag46 = 46;
                public const uint Zoneflag47 = 47;
                public const uint Zoneflag48 = 48;
                public const uint Zoneflag49 = 49;
                public const uint Zoneflag50 = 50;
                public const uint Zoneflag51 = 51;
                public const uint Zoneflag52 = 52;
                public const uint Zoneflag53 = 53;
                public const uint Zoneflag54 = 54;
                public const uint Zoneflag55 = 55;
                public const uint Zoneflag56 = 56;
                public const uint Zoneflag57 = 57;
                public const uint Zoneflag58 = 58;
                public const uint Zoneflag59 = 59;
                public const uint Zoneflag60 = 60;
                public const uint Zoneflag61 = 61;
                public const uint Zoneflag62 = 62;
                public const uint Zoneflag63 = 63;
                public const uint Zoneflag64 = 64;
                public const uint Zoneflag65 = 65;
                public const uint Zoneflag66 = 66;
                public const uint Zoneflag67 = 67;
                public const uint Zoneflag68 = 68;
                public const uint Zoneflag69 = 69;
                public const uint Zoneflag70 = 70;
                public const uint Zoneflag71 = 71;
                public const uint Zoneflag72 = 72;
                public const uint Zoneflag73 = 73;
                public const uint Zoneflag74 = 74;
                public const uint Zoneflag75 = 75;
                public const uint Zoneflag76 = 76;
                public const uint Zoneflag77 = 77;
                public const uint Zoneflag78 = 78;
                public const uint Zoneflag79 = 79;
                public const uint Zoneflag80 = 80;
                public const uint Zoneflag81 = 81;
                public const uint Zoneflag82 = 82;
                public const uint Zoneflag83 = 83;
                public const uint Zoneflag84 = 84;
                public const uint Zoneflag85 = 85;
                public const uint Zoneflag86 = 86;
                public const uint Zoneflag87 = 87;
                public const uint Zoneflag88 = 88;
                public const uint Zoneflag89 = 89;
                public const uint Zoneflag90 = 90;
                public const uint Zoneflag91 = 91;
                public const uint Zoneflag92 = 92;
                public const uint Zoneflag93 = 93;
                public const uint Zoneflag94 = 94;
                public const uint Zoneflag95 = 95;
                public const uint Zoneflag96 = 96;
                public const uint Zoneflag97 = 97;
                public const uint Zoneflag98 = 98;
                public const uint Zoneflag99 = 99;
                public const uint Zoneflag100 = 100;
                public const uint Zoneflag101 = 101;
                public const uint Zoneflag102 = 102;
                public const uint Zoneflag103 = 103;
                public const uint Zoneflag104 = 104;
                public const uint Zoneflag105 = 105;
                public const uint Zoneflag106 = 106;
                public const uint Zoneflag107 = 107;
                public const uint Zoneflag108 = 108;
                public const uint Zoneflag109 = 109;
                public const uint Zoneflag110 = 110;
                public const uint Zoneflag111 = 111;
                public const uint Zoneflag112 = 112;
                public const uint Zoneflag113 = 113;
                public const uint Zoneflag114 = 114;
                public const uint Zoneflag115 = 115;
                public const uint Zoneflag116 = 116;
                public const uint Zoneflag117 = 117;
                public const uint Zoneflag118 = 118;
                public const uint Zoneflag119 = 119;
                public const uint Zoneflag120 = 120;

            }
        }

        #endregion

        #region Construction and Initialization

        internal Zonerename(ComponentMediator componentMediator, uint controlJoinId)
        {
            ComponentMediator = componentMediator;
            Initialize(controlJoinId);
        }

        private void Initialize(uint controlJoinId)
        {
            ControlJoinId = controlJoinId; 
 
            _devices = new List<BasicTriListWithSmartObject>(); 
 
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag1, onZoneflag1);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag2, onZoneflag2);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag3, onZoneflag3);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag4, onZoneflag4);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag5, onZoneflag5);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag6, onZoneflag6);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag7, onZoneflag7);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag8, onZoneflag8);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag9, onZoneflag9);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag10, onZoneflag10);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag11, onZoneflag11);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag12, onZoneflag12);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag13, onZoneflag13);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag14, onZoneflag14);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag15, onZoneflag15);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag16, onZoneflag16);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag17, onZoneflag17);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag18, onZoneflag18);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag19, onZoneflag19);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag20, onZoneflag20);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag21, onZoneflag21);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag22, onZoneflag22);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag23, onZoneflag23);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag24, onZoneflag24);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag25, onZoneflag25);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag26, onZoneflag26);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag27, onZoneflag27);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag28, onZoneflag28);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag29, onZoneflag29);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag30, onZoneflag30);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag31, onZoneflag31);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag32, onZoneflag32);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag33, onZoneflag33);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag34, onZoneflag34);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag35, onZoneflag35);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag36, onZoneflag36);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag37, onZoneflag37);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag38, onZoneflag38);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag39, onZoneflag39);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag40, onZoneflag40);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag41, onZoneflag41);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag42, onZoneflag42);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag43, onZoneflag43);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag44, onZoneflag44);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag45, onZoneflag45);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag46, onZoneflag46);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag47, onZoneflag47);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag48, onZoneflag48);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag49, onZoneflag49);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag50, onZoneflag50);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag51, onZoneflag51);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag52, onZoneflag52);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag53, onZoneflag53);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag54, onZoneflag54);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag55, onZoneflag55);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag56, onZoneflag56);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag57, onZoneflag57);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag58, onZoneflag58);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag59, onZoneflag59);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag60, onZoneflag60);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag61, onZoneflag61);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag62, onZoneflag62);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag63, onZoneflag63);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag64, onZoneflag64);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag65, onZoneflag65);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag66, onZoneflag66);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag67, onZoneflag67);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag68, onZoneflag68);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag69, onZoneflag69);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag70, onZoneflag70);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag71, onZoneflag71);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag72, onZoneflag72);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag73, onZoneflag73);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag74, onZoneflag74);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag75, onZoneflag75);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag76, onZoneflag76);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag77, onZoneflag77);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag78, onZoneflag78);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag79, onZoneflag79);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag80, onZoneflag80);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag81, onZoneflag81);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag82, onZoneflag82);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag83, onZoneflag83);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag84, onZoneflag84);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag85, onZoneflag85);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag86, onZoneflag86);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag87, onZoneflag87);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag88, onZoneflag88);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag89, onZoneflag89);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag90, onZoneflag90);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag91, onZoneflag91);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag92, onZoneflag92);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag93, onZoneflag93);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag94, onZoneflag94);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag95, onZoneflag95);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag96, onZoneflag96);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag97, onZoneflag97);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag98, onZoneflag98);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag99, onZoneflag99);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag100, onZoneflag100);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag101, onZoneflag101);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag102, onZoneflag102);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag103, onZoneflag103);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag104, onZoneflag104);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag105, onZoneflag105);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag106, onZoneflag106);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag107, onZoneflag107);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag108, onZoneflag108);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag109, onZoneflag109);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag110, onZoneflag110);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag111, onZoneflag111);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag112, onZoneflag112);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag113, onZoneflag113);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag114, onZoneflag114);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag115, onZoneflag115);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag116, onZoneflag116);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag117, onZoneflag117);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag118, onZoneflag118);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag119, onZoneflag119);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Zoneflag120, onZoneflag120);

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

        public event EventHandler<UIEventArgs> Zoneflag1;
        private void onZoneflag1(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag1;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag2;
        private void onZoneflag2(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag2;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag3;
        private void onZoneflag3(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag3;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag4;
        private void onZoneflag4(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag4;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag5;
        private void onZoneflag5(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag5;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag6;
        private void onZoneflag6(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag6;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag7;
        private void onZoneflag7(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag7;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag8;
        private void onZoneflag8(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag8;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag9;
        private void onZoneflag9(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag9;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag10;
        private void onZoneflag10(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag10;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag11;
        private void onZoneflag11(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag11;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag12;
        private void onZoneflag12(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag12;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag13;
        private void onZoneflag13(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag13;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag14;
        private void onZoneflag14(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag14;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag15;
        private void onZoneflag15(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag15;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag16;
        private void onZoneflag16(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag16;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag17;
        private void onZoneflag17(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag17;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag18;
        private void onZoneflag18(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag18;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag19;
        private void onZoneflag19(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag19;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag20;
        private void onZoneflag20(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag20;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag21;
        private void onZoneflag21(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag21;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag22;
        private void onZoneflag22(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag22;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag23;
        private void onZoneflag23(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag23;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag24;
        private void onZoneflag24(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag24;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag25;
        private void onZoneflag25(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag25;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag26;
        private void onZoneflag26(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag26;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag27;
        private void onZoneflag27(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag27;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag28;
        private void onZoneflag28(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag28;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag29;
        private void onZoneflag29(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag29;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag30;
        private void onZoneflag30(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag30;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag31;
        private void onZoneflag31(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag31;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag32;
        private void onZoneflag32(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag32;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag33;
        private void onZoneflag33(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag33;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag34;
        private void onZoneflag34(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag34;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag35;
        private void onZoneflag35(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag35;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag36;
        private void onZoneflag36(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag36;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag37;
        private void onZoneflag37(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag37;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag38;
        private void onZoneflag38(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag38;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag39;
        private void onZoneflag39(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag39;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag40;
        private void onZoneflag40(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag40;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag41;
        private void onZoneflag41(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag41;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag42;
        private void onZoneflag42(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag42;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag43;
        private void onZoneflag43(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag43;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag44;
        private void onZoneflag44(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag44;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag45;
        private void onZoneflag45(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag45;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag46;
        private void onZoneflag46(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag46;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag47;
        private void onZoneflag47(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag47;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag48;
        private void onZoneflag48(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag48;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag49;
        private void onZoneflag49(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag49;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag50;
        private void onZoneflag50(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag50;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag51;
        private void onZoneflag51(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag51;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag52;
        private void onZoneflag52(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag52;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag53;
        private void onZoneflag53(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag53;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag54;
        private void onZoneflag54(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag54;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag55;
        private void onZoneflag55(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag55;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag56;
        private void onZoneflag56(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag56;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag57;
        private void onZoneflag57(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag57;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag58;
        private void onZoneflag58(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag58;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag59;
        private void onZoneflag59(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag59;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag60;
        private void onZoneflag60(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag60;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag61;
        private void onZoneflag61(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag61;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag62;
        private void onZoneflag62(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag62;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag63;
        private void onZoneflag63(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag63;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag64;
        private void onZoneflag64(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag64;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag65;
        private void onZoneflag65(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag65;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag66;
        private void onZoneflag66(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag66;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag67;
        private void onZoneflag67(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag67;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag68;
        private void onZoneflag68(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag68;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag69;
        private void onZoneflag69(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag69;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag70;
        private void onZoneflag70(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag70;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag71;
        private void onZoneflag71(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag71;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag72;
        private void onZoneflag72(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag72;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag73;
        private void onZoneflag73(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag73;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag74;
        private void onZoneflag74(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag74;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag75;
        private void onZoneflag75(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag75;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag76;
        private void onZoneflag76(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag76;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag77;
        private void onZoneflag77(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag77;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag78;
        private void onZoneflag78(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag78;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag79;
        private void onZoneflag79(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag79;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag80;
        private void onZoneflag80(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag80;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag81;
        private void onZoneflag81(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag81;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag82;
        private void onZoneflag82(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag82;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag83;
        private void onZoneflag83(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag83;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag84;
        private void onZoneflag84(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag84;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag85;
        private void onZoneflag85(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag85;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag86;
        private void onZoneflag86(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag86;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag87;
        private void onZoneflag87(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag87;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag88;
        private void onZoneflag88(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag88;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag89;
        private void onZoneflag89(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag89;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag90;
        private void onZoneflag90(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag90;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag91;
        private void onZoneflag91(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag91;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag92;
        private void onZoneflag92(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag92;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag93;
        private void onZoneflag93(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag93;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag94;
        private void onZoneflag94(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag94;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag95;
        private void onZoneflag95(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag95;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag96;
        private void onZoneflag96(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag96;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag97;
        private void onZoneflag97(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag97;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag98;
        private void onZoneflag98(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag98;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag99;
        private void onZoneflag99(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag99;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag100;
        private void onZoneflag100(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag100;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag101;
        private void onZoneflag101(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag101;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag102;
        private void onZoneflag102(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag102;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag103;
        private void onZoneflag103(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag103;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag104;
        private void onZoneflag104(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag104;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag105;
        private void onZoneflag105(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag105;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag106;
        private void onZoneflag106(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag106;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag107;
        private void onZoneflag107(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag107;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag108;
        private void onZoneflag108(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag108;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag109;
        private void onZoneflag109(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag109;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag110;
        private void onZoneflag110(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag110;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag111;
        private void onZoneflag111(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag111;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag112;
        private void onZoneflag112(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag112;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag113;
        private void onZoneflag113(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag113;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag114;
        private void onZoneflag114(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag114;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag115;
        private void onZoneflag115(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag115;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag116;
        private void onZoneflag116(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag116;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag117;
        private void onZoneflag117(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag117;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag118;
        private void onZoneflag118(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag118;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag119;
        private void onZoneflag119(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag119;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Zoneflag120;
        private void onZoneflag120(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Zoneflag120;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }


        #endregion

        #region Overrides

        public override int GetHashCode()
        {
            return (int)ControlJoinId;
        }

        public override string ToString()
        {
            return string.Format("Contract: {0} Component: {1} HashCode: {2} {3}", "Zonerename", GetType().Name, GetHashCode(), UserObject != null ? "UserObject: " + UserObject : null);
        }

        #endregion

        #region IDisposable

        public bool IsDisposed { get; set; }

        public void Dispose()
        {
            if (IsDisposed)
                return;

            IsDisposed = true;

            Zoneflag1 = null;
            Zoneflag2 = null;
            Zoneflag3 = null;
            Zoneflag4 = null;
            Zoneflag5 = null;
            Zoneflag6 = null;
            Zoneflag7 = null;
            Zoneflag8 = null;
            Zoneflag9 = null;
            Zoneflag10 = null;
            Zoneflag11 = null;
            Zoneflag12 = null;
            Zoneflag13 = null;
            Zoneflag14 = null;
            Zoneflag15 = null;
            Zoneflag16 = null;
            Zoneflag17 = null;
            Zoneflag18 = null;
            Zoneflag19 = null;
            Zoneflag20 = null;
            Zoneflag21 = null;
            Zoneflag22 = null;
            Zoneflag23 = null;
            Zoneflag24 = null;
            Zoneflag25 = null;
            Zoneflag26 = null;
            Zoneflag27 = null;
            Zoneflag28 = null;
            Zoneflag29 = null;
            Zoneflag30 = null;
            Zoneflag31 = null;
            Zoneflag32 = null;
            Zoneflag33 = null;
            Zoneflag34 = null;
            Zoneflag35 = null;
            Zoneflag36 = null;
            Zoneflag37 = null;
            Zoneflag38 = null;
            Zoneflag39 = null;
            Zoneflag40 = null;
            Zoneflag41 = null;
            Zoneflag42 = null;
            Zoneflag43 = null;
            Zoneflag44 = null;
            Zoneflag45 = null;
            Zoneflag46 = null;
            Zoneflag47 = null;
            Zoneflag48 = null;
            Zoneflag49 = null;
            Zoneflag50 = null;
            Zoneflag51 = null;
            Zoneflag52 = null;
            Zoneflag53 = null;
            Zoneflag54 = null;
            Zoneflag55 = null;
            Zoneflag56 = null;
            Zoneflag57 = null;
            Zoneflag58 = null;
            Zoneflag59 = null;
            Zoneflag60 = null;
            Zoneflag61 = null;
            Zoneflag62 = null;
            Zoneflag63 = null;
            Zoneflag64 = null;
            Zoneflag65 = null;
            Zoneflag66 = null;
            Zoneflag67 = null;
            Zoneflag68 = null;
            Zoneflag69 = null;
            Zoneflag70 = null;
            Zoneflag71 = null;
            Zoneflag72 = null;
            Zoneflag73 = null;
            Zoneflag74 = null;
            Zoneflag75 = null;
            Zoneflag76 = null;
            Zoneflag77 = null;
            Zoneflag78 = null;
            Zoneflag79 = null;
            Zoneflag80 = null;
            Zoneflag81 = null;
            Zoneflag82 = null;
            Zoneflag83 = null;
            Zoneflag84 = null;
            Zoneflag85 = null;
            Zoneflag86 = null;
            Zoneflag87 = null;
            Zoneflag88 = null;
            Zoneflag89 = null;
            Zoneflag90 = null;
            Zoneflag91 = null;
            Zoneflag92 = null;
            Zoneflag93 = null;
            Zoneflag94 = null;
            Zoneflag95 = null;
            Zoneflag96 = null;
            Zoneflag97 = null;
            Zoneflag98 = null;
            Zoneflag99 = null;
            Zoneflag100 = null;
            Zoneflag101 = null;
            Zoneflag102 = null;
            Zoneflag103 = null;
            Zoneflag104 = null;
            Zoneflag105 = null;
            Zoneflag106 = null;
            Zoneflag107 = null;
            Zoneflag108 = null;
            Zoneflag109 = null;
            Zoneflag110 = null;
            Zoneflag111 = null;
            Zoneflag112 = null;
            Zoneflag113 = null;
            Zoneflag114 = null;
            Zoneflag115 = null;
            Zoneflag116 = null;
            Zoneflag117 = null;
            Zoneflag118 = null;
            Zoneflag119 = null;
            Zoneflag120 = null;
        }

        #endregion

    }
}
