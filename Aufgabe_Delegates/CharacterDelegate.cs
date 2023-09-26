using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_Delegates
{
    internal class CharacterDelegate
    {
        public void UpperCase(string t)
        {
            Console.WriteLine( Convert.ToString(t).ToUpper() );
        }
        public void LowerCase(string t)
        {
            Console.WriteLine(Convert.ToString(t).ToLower());
        }
        public void UpperLower(string t)
        {
           
        }
    }
}
