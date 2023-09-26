using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Aufgabe_Delegates
{
    delegate void CharacterDelagete(string s);
    internal class Program
    {
        static void Main(string[] args)

        {

            CharacterDelagete characterDelagete;

            characterDelagete = new CharacterDelagete(stringMethoden.LowerCase);

            Console.WriteLine("Tololower(Helaladank): ");
            characterDelagete("Helaladank");

            Console.WriteLine();
            characterDelagete = new CharacterDelagete(stringMethoden.UpperCase);

            Console.WriteLine("Tololower(Helaladank): ");
            characterDelagete("Helaladank");
        }
    }
}
