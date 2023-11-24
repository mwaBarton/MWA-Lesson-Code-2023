using System;
using System.IO;

namespace L125_6___Text_Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = "shopping.txt";

            // Easy way (writing)
            File.WriteAllText(filename, "yeast\nmilk\neggs\n");

            // East way (reading)
            string contents;

            contents = File.ReadAllText(filename);

            Console.WriteLine($"Contents of {filename} are \"{contents.Replace("\n", ", ")}\"");


            string[] lines = File.ReadAllLines(filename);
            lines[2] = "bread";

            File.WriteAllLines(filename, lines);

            // Proper way (write)
            using (StreamWriter writer = new StreamWriter(filename, false))
            {
                writer.WriteLine("yeast");
            }

            // Proper way (reading)
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;

                while (reader.EndOfStream == false)
                {
                    line = reader.ReadLine();
                    Console.WriteLine(line);
                }
            }



            Console.ReadKey();
        }
    }
}
