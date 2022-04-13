using System;
using System.Drawing;
using SavasOyunu.Library.Abstract;

namespace SavasOyunu.Library.Concrete
{
    internal class Ucak : Cisim
    {

        private static readonly Random Random = new Random();

        public Ucak(Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
        {

            Left = Random.Next(hareketAlaniBoyutlari.Width - Width + 1);
        }
    }
}