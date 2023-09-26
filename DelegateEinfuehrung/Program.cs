using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEinfuehrung
{
   delegate int CalculateHandler(int ivar1, int ivar2);

    internal class Program
        {

            static void Main(string[] args)
            {

                Console.WriteLine("Hello, Delegate!");
                //int ergebnis = Demo.Addition(7,8);
                //Console.WriteLine(ergebnis);

                CalculateHandler calculate;
                calculate = new CalculateHandler(Demo.Subtraktion);
                int ergebnis = calculate(7, 8);
                Console.WriteLine(ergebnis);

                calculate = new CalculateHandler(Demo.Addition);
                ergebnis = calculate(7, 8);
                Console.WriteLine(ergebnis);

                calculate = new CalculateHandler(Demo.Multiplikation);
                ergebnis = calculate(7, 8);
                Console.WriteLine(ergebnis);

                calculate = new CalculateHandler(Demo.Division);
                ergebnis = calculate(10, 2);
                Console.WriteLine(ergebnis);

                calculate = new CalculateHandler(Demo.Subtraktion);
                ergebnis = calculate(7, 8);

                Console.WriteLine(ergebnis);
                /// Rechner-Objekt

                Rechner r = new Rechner();
                //Console.WriteLine(r.BerechneAusRechner(7,8));
                calculate = new CalculateHandler(r.Subtraktion);
                ergebnis = calculate(7, 8);
                Console.WriteLine(ergebnis);

                calculate = new CalculateHandler(r.Addition);
                ergebnis = calculate(7, 8);
                Console.WriteLine(ergebnis);


                // Multicastdelegate
                CalculateHandler a = Demo.Addition;
                CalculateHandler b = Demo.Subtraktion;
                CalculateHandler c = a + b;
                Console.WriteLine("multicast");
                int erg = c(7, 8);

                Console.WriteLine(erg);
            }
    }
}
