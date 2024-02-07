using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L148___Classes_and_Objects
{
    internal class Drink
    {
        public string type;
        public bool isAlcoholic;
        public double viscosity;

        public void DrinkIt()
        {
            if (isAlcoholic)
            {
                Console.WriteLine("You got drunk. Go home (in a taxi).");
            } 
            else if (viscosity > 100) 
            {
                Console.WriteLine("Bit gloopy...");
            }
            else {
                Console.WriteLine("You drank the drink. Well done you.");
            }
        }
    }
}
