using System;

namespace Kassenautomat
{
    internal class CoinsQuantity
    {
        public int FuenfFraenkler { get; private set; }
        public int ZweiFraenkler { get; private set; }
        public int EinFraenkler { get; private set; }
        public int FuenfzigRaeppler { get; private set; }
        public int ZwanzigRaeppler { get; private set; }
        public int ZehnRaeppler { get; private set; }

        public void Add(int rappenGroesse)
        {
            switch (rappenGroesse)
            {
                case 10:
                    ZehnRaeppler += 1;
                    break;
                case 20:
                    ZwanzigRaeppler += 1;
                    break;
                case 50:
                    FuenfzigRaeppler += 1;
                    break;
                case 100:
                    EinFraenkler += 1;
                    break;
                case 200:
                    ZweiFraenkler += 1;
                    break;
                case 500:
                    FuenfFraenkler += 1;
                    break;
                default:
                    Console.WriteLine("Gibts ned.... Eigentlich wuerde hier eine Exception geschmissen....");
                    break;
            }
        }

        public void Reset()
        {
            ZehnRaeppler = 0;
            ZwanzigRaeppler = 0;
            FuenfzigRaeppler = 0;
            EinFraenkler = 0;
            ZweiFraenkler = 0;
            FuenfFraenkler = 0;
        }
        public int GetValue()
        {
            int value = 0;
            value += ZehnRaeppler * 10;
            value += ZwanzigRaeppler * 20;
            value += FuenfzigRaeppler * 50;
            value += EinFraenkler * 100;
            value += ZweiFraenkler * 200;
            value += FuenfFraenkler * 500;
            return value;
        }

        public static CoinsQuantity operator +(CoinsQuantity c1, CoinsQuantity c2)
        {
            c1.ZehnRaeppler += c2.ZehnRaeppler;
            c1.ZwanzigRaeppler += c2.ZwanzigRaeppler;
            c1.FuenfzigRaeppler += c2.FuenfzigRaeppler;
            c1.EinFraenkler += c2.EinFraenkler;
            c1.ZweiFraenkler += c2.ZweiFraenkler;
            c1.FuenfFraenkler += c2.FuenfFraenkler;
            return c1;
        }
    }
}