using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarpKern
{
    internal class WarpKern
    {
        public int WarpKernTemperatur { get; set; } = 0;
        public event EventHandler<WarpKernEventArgs> TempMeldungEvent;
        public event EventHandler<WarpKernEventArgs> TempWarnungEvent;

        Random rnd= new Random();

        public void TempÄndern() 
        { 
            WarpKernEventArgs wkea = new WarpKernEventArgs();
            wkea.PreTemp = WarpKernTemperatur;

            WarpKernTemperatur = rnd.Next(0,800);

            wkea.CurrTemp = WarpKernTemperatur;
            wkea.CurrTime = DateTime.Now.ToLongTimeString();

            if (WarpKernTemperatur > 500)
            {
                TempWarnungEvent(this, wkea);
            }

            TempWarnungEvent(this, wkea);
        }


    }
}
