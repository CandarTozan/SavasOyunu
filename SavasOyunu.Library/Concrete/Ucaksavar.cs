using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SavasOyunu.Library.Abstract;

namespace SavasOyunu.Library.Concrete
{
    internal class Ucaksavar : Cisim
    {
        public Ucaksavar(int panelGenisligi)
        {
            Left = (panelGenisligi - Width) / 2;
        }
    }
}
