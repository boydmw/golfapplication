using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfApplication
{
    public class GolfClubs
    {
        public Manufacturer manufacturer;
        public AvailableClubs clubType;
        public float averageDistance;

        //Allows you to translate the name of the golf club into a user friendly string.
        public string Translate(AvailableClubs club)
        {
            switch (club)
            {
                case AvailableClubs.Putter:
                    return "Putter";
                case AvailableClubs.LobWedge:
                    return "Lob Wedge";
                case AvailableClubs.SandWedge:
                    return "Sand Wedge";
                case AvailableClubs.PitchingWedge:
                    return "Pitching Wedge";
                case AvailableClubs.GapWedge:
                    return "Gap Wedge";
                case AvailableClubs.NineIron:
                    return "9 Iron";
                case AvailableClubs.EightIron:
                    return "8 Iron";
                case AvailableClubs.SevenIron:
                    return "7 Iron";
                case AvailableClubs.SixIron:
                    return "6 Iron";
                case AvailableClubs.FiveIron:
                    return "5 Iron";
                case AvailableClubs.FourIron:
                    return "4 Iron";
                case AvailableClubs.ThreeIron:
                    return "3 Iron";
                case AvailableClubs.TwoIron:
                    return "2 Iron";
                case AvailableClubs.FiveWood:
                    return "5 Wood";
                case AvailableClubs.ThreeWood:
                    return "3 Wood";
                case AvailableClubs.Driver:
                    return "Driver";
                default:
                    return "Unknown";
            }
        }

        //Allows you to translate the int clubType into enum
        public AvailableClubs Translate(int clubType)
        {
            switch (clubType)
            {
                case 1:
                    return AvailableClubs.Putter;
                case 2:
                    return AvailableClubs.LobWedge;
                case 3:
                    return AvailableClubs.SandWedge;
                case 4:
                    return AvailableClubs.PitchingWedge;
                case 5:
                    return AvailableClubs.GapWedge;
                case 6:
                    return AvailableClubs.NineIron;
                case 7:
                    return AvailableClubs.EightIron;
                case 8:
                    return AvailableClubs.SevenIron;
                case 9:
                    return AvailableClubs.SixIron;
                case 10:
                    return AvailableClubs.FiveIron;
                case 11:
                    return AvailableClubs.FourIron;
                case 12:
                    return AvailableClubs.ThreeIron;
                case 13:
                    return AvailableClubs.TwoIron;
                case 14:
                    return AvailableClubs.FiveWood;
                case 15:
                    return AvailableClubs.ThreeWood;
                case 16:
                    return AvailableClubs.Driver;
                default:
                    return AvailableClubs.Unknown;
            }
        }

        //Allows you to translate the manufacturer name into a user friendly string.
        public string Translate(Manufacturer manufacturer)
        {
            switch (manufacturer)
            {
                case Manufacturer.Titleist:
                    return "Titleist";
                case Manufacturer.Calloway:
                    return "Calloway";
                case Manufacturer.Nike:
                    return "Nike";
                case Manufacturer.TaylorMade:
                    return "Taylor Made";
                case Manufacturer.Ping:
                    return "Ping";
                default:
                    return "Unknown";
            }
        }
    }
}
