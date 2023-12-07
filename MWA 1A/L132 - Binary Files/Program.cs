using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace L132___Binary_Files
{
    internal class Program
    {
        struct House
        {
            public int houseNumber;
            public string street;
            public bool occupied;
        }

        static void Main(string[] args)
        {
            string filename = "houses.bin";

            List<House> houses = new List<House>();
            House tempHouse = new House();

            tempHouse.houseNumber = 28;
            tempHouse.street = "Dudley Hill";
            tempHouse.occupied = true;
            houses.Add(tempHouse);

            tempHouse.houseNumber = 10;
            tempHouse.street = "Privet Drive";
            tempHouse.occupied = false;
            houses.Add(tempHouse);

            // Writing to file
            using (BinaryWriter writer = new BinaryWriter(File.Open(filename, FileMode.OpenOrCreate)))
            {
                // Write the length of the list
                writer.Write(houses.Count);

                // Write each house
                foreach (House house in houses)
                {
                    writer.Write(house.houseNumber);
                    writer.Write(house.street);
                    writer.Write(house.occupied);
                }
            }

            // Reading from file
            List<House> housesRead = new List<House>();

            using (BinaryReader reader = new BinaryReader(File.Open(filename, FileMode.OpenOrCreate)))
            {
                int numHouses = reader.ReadInt32();

                for (int i = 0; i < numHouses; i++)
                {
                    House tHouse = new House();
                    tHouse.houseNumber = reader.ReadInt32();
                    tHouse.street = reader.ReadString();
                    tHouse.occupied = reader.ReadBoolean();
                }
            }

            // Print the data
            foreach (House house in houses)
            {
                PrintHouse(house);
            }

            Console.ReadKey();
        }

        static void PrintHouse(House house)
        {
            Console.WriteLine(house.houseNumber + " " + house.street + ": " + house.occupied);
        }
    }
}
