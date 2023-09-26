using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Beispiel
{
    delegate int CalculateHandler(int ivar1, int ivar2);
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateHandler calculate;
            Console.WriteLine("Delegate me!");

            Console.ReadKey();

            CalculateHandler calculate;  // Delegate-Variable
            int ergebnis;

            // auf Methode zeigen
            calculate = new CalculateHandler(Demo.Addition);

            // Der eigentliche Methoden-Aufruf

            ergebnis = calculate(7, 8);
            Console.WriteLine(ergebnis);

            Console.WriteLine("Delegate me!");
            Console.ReadKey();
        }
    }
}
