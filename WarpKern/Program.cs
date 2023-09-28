using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WarpKern_Aufgabe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WarpKern wk = new WarpKern();

            WarpkernKonsole wkc= new WarpkernKonsole();

            wk.TempWarnungEvent += wkc.OnTempWarnung;
            wk.TempMeldungEvent += wkc.OnTempMeldung;

            for (int i = 0; i < 10; i++)
            {
                wk.TempÄndern();

                Console.WriteLine();

                Thread.Sleep(1000);
            }
            Console.ReadLine();
        }
    }
}
