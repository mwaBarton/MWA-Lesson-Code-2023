using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L125___Structures
{
    internal class Program
    {
        struct Pencilcase
        {
            public int numberOfPencils;
            public int numberOfPens;
            public bool isThereACompassInThere;
            public List<string> penColours;
            public string name;
        }

        static void PrintPencilcases(Pencilcase[] cases)
        {
            foreach(Pencilcase p in cases) {
                Console.WriteLine($"{p.name} is a pencilcase " +
                    $"with {p.numberOfPens} pens of {p.penColours.Count} colours.");
            }
        }

        static void Main(string[] args)
        {
            Pencilcase jeremy = new Pencilcase();

            jeremy.name = "Jeremy";
            jeremy.numberOfPens = 4;
            jeremy.numberOfPencils = 1;
            jeremy.penColours = new List<string>() { "Black", "Red" };

            Pencilcase[] pencilcases = new Pencilcase[2];
            pencilcases[0] = jeremy;
            pencilcases[1].name = "Jonathon";
            pencilcases[1].isThereACompassInThere=true;
            pencilcases[1].numberOfPencils = 2;
            pencilcases[1].numberOfPens = 11;
            pencilcases[1].penColours = new List<string>() { "Green", "Yellow", "Black", "Pink", "Blue", "Red" };

            PrintPencilcases(pencilcases);



            Console.ReadKey();
        }
    }
}
