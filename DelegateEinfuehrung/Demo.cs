using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEinfuehrung
{
    internal class Demo
    {
        public static int Addition(int x, int y)
        {
            return x + y;
        }
        public static int Subtraktion(int x, int y)
        {
            return x - y;
        }
        public static int Multiplikation(int x, int y)
        {
            return x * y;
        }
        public static int Division(int x, int y)
        {
            if (y == 0)
            {
                return 0;
            }
            return x / y;
        }
    }
}
