using System;
using System.Drawing;
using SavasOyunu.Library.Abstract;

namespace SavasOyunu.Library.Concrete
{
    internal class Mermi : Cisim
    {
        public Mermi(Size hareketAlaniBoyutlari, int namluOrtasiX) : base(hareketAlaniBoyutlari)
        {
            BaslangicKonumunuAyarla(namluOrtasiX);
        }

        private void BaslangicKonumunuAyarla(int namluOrtasiX)
        {
            Bottom = HareketAlaniBoyutlari.Height;
            Center = namluOrtasiX;
            HareketMesafesi = (int) (Height * 1.5);
        }
    }
}
