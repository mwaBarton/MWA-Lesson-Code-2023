using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L158___Searching
{


    internal class Program
    {
        static bool linearSearch(int[] array, int searchingFor)
        {
            foreach (int num in array)
            {
                if (num == searchingFor) return true;
            }
            return false;
        }
        
        static bool binarySearch(int[] array, int searchingFor)
        {
            int lower, upper;
            lower = 0;
            upper = array.Length - 1;

            while (lower <= upper)
            {
                int midIndex = (lower + upper) / 2;
                int midpoint = array[midIndex];

                if (midpoint == searchingFor)
                {
                    return true;
                } else if (midpoint < searchingFor)
                {
                    lower = midIndex + 1;
                } else if (midpoint > searchingFor)
                {
                    upper = midIndex - 1;
                }
            }

            return false;
        }


        static void Main(string[] args)
        {
            int[] nums = { 4, 5, 6, 8, 12, 38, 47, 9000 };


            Console.WriteLine(linearSearch(nums, 12));
            Console.WriteLine(binarySearch(nums, 38));

            Console.ReadKey();
        }
    }
}
