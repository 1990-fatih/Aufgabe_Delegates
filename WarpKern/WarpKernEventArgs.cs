using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarpKern
{
    internal class WarpKernEventArgs
    {
        public int PreTemp { get; set; }
        public int CurrTemp { get; set; }

        public string CurrTime { get; set; }

    }
}
