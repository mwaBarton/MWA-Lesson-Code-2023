using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace L132___Binary_Files
{
    struct Chocolate
    {
        public string wrapperColour;
        public int mass;
        public bool isOpen;
    }
    internal class Program
    {
        static Chocolate InputChocolate()
        {
            Chocolate c;

            Console.Write("Enter wrapper colour: ");
            c.wrapperColour = Console.ReadLine();
            Console.Write("Enter mass: ");
            c.mass = int.Parse(Console.ReadLine());
            Console.Write("Is it open? (yes/no)");
            string answer = Console.ReadLine().ToLower();
            c.isOpen = (answer == "yes");

            return c;
        }

        static void PrintChocolate(Chocolate c)
        {
            Console.WriteLine($"{c.wrapperColour} chocolate, mass={c.mass}kg, open={(c.isOpen ? "Yes" : "No")}");
        }

        static void WriteChocolateToFile(string filename, List<Chocolate> chocolateList)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(filename, FileMode.OpenOrCreate)))
            {
                // Firstly, write the length of the list
                writer.Write(chocolateList.Count);

                foreach(Chocolate choc in chocolateList)
                {
                    writer.Write(choc.wrapperColour);
                    writer.Write(choc.mass);
                    writer.Write(choc.isOpen);
                }
            }
        }

        static List<Chocolate> ReadChocolateFromFile(string filename)
        {
            List<Chocolate> chocolateList = new List<Chocolate>();

            using (BinaryReader reader = new BinaryReader(File.Open(filename, FileMode.OpenOrCreate)))
            {
                int numChocolate = reader.ReadInt32();

                for (int i = 0; i < numChocolate; i++)
                {
                    Chocolate c;

                    c.wrapperColour = reader.ReadString();
                    c.mass = reader.ReadInt32();
                    c.isOpen = reader.ReadBoolean();

                    chocolateList.Add(c);
                }
            }

            return chocolateList;
        }

        static void Main(string[] args)
        {
            string filename = "chocolates.choc";

            List<Chocolate> myKitchenCupboard = new List<Chocolate>();

            //myKitchenCupboard.Add(InputChocolate());
            //myKitchenCupboard.Add(InputChocolate());

            //WriteChocolateToFile(filename, myKitchenCupboard);

            myKitchenCupboard = ReadChocolateFromFile(filename);

            foreach (Chocolate chocolate in myKitchenCupboard)
            {
                PrintChocolate(chocolate);
            }

            Console.ReadKey();
        }
    }
}
