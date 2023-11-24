using System;
using System.IO;

namespace L126___Text_Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = "kangaroos.txt";

            // Easy way
            File.WriteAllText(filename, "Bob\nkanga\nroo");

            string contents;
            contents = File.ReadAllText(filename);
            Console.WriteLine(contents.Replace("\n", ", "));

            // Proper way (write)
            using (StreamWriter writer = new StreamWriter(filename, true))
            {
                writer.WriteLine("bob");
            }

            // Proper way (reading)
            //using (StreamReader reader = new StreamReader(filename))
            //{
            //    string line;
            //    while (reader.EndOfStream == false)
            //    {
            //        line = reader.ReadLine();
            //        Console.WriteLine(line);
            //    }
            //}


            

                Console.ReadKey();
        }
    }
}
