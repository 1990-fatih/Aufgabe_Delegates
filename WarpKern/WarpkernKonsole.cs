using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarpKern_Aufgabe
{
    internal class WarpkernKonsole
    {
        public void OnTempMeldung(object sender, WarpKernEventArgs e) { 
        
            WarpKern warpKern= (WarpKern)sender;

            Console.WriteLine($"Änderung der Warpkern-Temperatur um {e.CurrTime}:");
            Console.WriteLine($"    Alte Temperatur: {e.PreTemp, 3}°");
            Console.WriteLine($"    Neue Temperatur: {e.CurrTime, 3}°");

        }

        public void OnTempWarnung(Object sender, WarpKernEventArgs e) {

            WarpKern wk = (WarpKern)sender;

            Console.WriteLine("!!!  WARNUNG !!!");  
            Console.WriteLine($"Warpkern-Temperetur zu hoch({e.CurrTemp}°)");
            Console.WriteLine("!!!  WARNUNG !!!");

        }

    }
}
