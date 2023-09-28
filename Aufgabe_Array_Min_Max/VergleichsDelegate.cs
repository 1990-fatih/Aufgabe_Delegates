using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_Array_Min_Max
{
    internal class VergleichsDelegate
    {
        public static bool istKleiner(int a, int b)           
        {
            return a < b;
        }
        public static bool istGrösser(int a, int b)
        {
            return a > b;
        }
    }
}
