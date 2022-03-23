using System;
using SavasOyunu.Library.Enum;

namespace SavasOyunu.Library.Interface
{
    internal interface IOyun
    {
        bool DevamEdiyorMu { get; }
        TimeSpan GecenSure { get; }

        void Baslat();
        void AtesEt();
        void UcaksavariHareketEttir(Yon yon);

    }
}
