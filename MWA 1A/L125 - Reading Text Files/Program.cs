using System;
using System.IO;

namespace L125___Reading_Text_Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = "menu.txt";

            // The easy way
            //string contents = File.ReadAllText(filename);

            //Console.WriteLine(contents);



            // The proper way
            using (StreamReader reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    Console.WriteLine(line);
                }
            }



            // WRITING TO TEXT FILES

            // The easy way

            string toWrite = "Jeff Bezos\nElon Musk";
            string fileName = "billionaires.bil";

            //File.WriteAllText(fileName, toWrite);


            // The proper way
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine("Jeff Bezos");
                writer.WriteLine("Elon Musk");
            }


            Console.ReadKey();
        }
    }
}
