using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aufgabe_Array_Min_Max
{
    delegate bool Vergleichs(int a, int b);
    internal class Methode
    {

        Vergleichs vergleichs;

        vergleichs=new Vergleichs(VergleichsDelegate.);



        public static int Limit(del(), int[] array)
        {
            int Result = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (del(array[i],Result))
                {
                    Result = array[i];
                }
            }


        }
    }
}
