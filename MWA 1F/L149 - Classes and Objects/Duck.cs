using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L149___Classes_and_Objects
{
    internal class Duck
    {
        public double mass;
        public string colour;
        public int secondsUntilExpiry;
        public bool isAlive;

        public string Quack()
        {
            string result = "Nothing was said.";

            if (isAlive) {
                result = "Quack";
                
                secondsUntilExpiry -= 1;
                if (secondsUntilExpiry == 0)
                {
                    isAlive = false;
                }
            }

            return result;
        }
    }
}
