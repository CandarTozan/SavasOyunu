using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SavasOyunu.Library.Enum;
using SavasOyunu.Library.Interface;
using System.Windows.Forms;

namespace SavasOyunu.Library.Concrete
{
    public class Oyun : IOyun
    {
        public bool DevamEdiyorMu { get; private set; }

        public TimeSpan GecenSure { get; }

        public void AtesEt()
        {
            throw new NotImplementedException();
        }

        public void Baslat()
        {
            if (DevamEdiyorMu) return;
            
            DevamEdiyorMu = true;
                        
        }

        private void Bitir()
        {
            if (!DevamEdiyorMu) return;

            DevamEdiyorMu = false;
        }

        public void UcaksavariHareketEttir(Yon yon)
        {
            throw new NotImplementedException();
        }
    }
}
