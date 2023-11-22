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

            Console.ReadKey();
        }
    }
}
