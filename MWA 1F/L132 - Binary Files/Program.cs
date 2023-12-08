using System;
using System.Collections.Generic;
using System.IO;

namespace L132___Binary_Files
{
    internal class Program
    {
        struct Player
        {
            public string Name;
            public int Age;
            public double Height;
            public bool Alive;
        }

        static Player InputPlayer()
        {
            Player result;
            Console.Write("Enter name: ");
            result.Name = Console.ReadLine();
            Console.Write("Enter age: ");
            result.Age = int.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            result.Height = double.Parse(Console.ReadLine());
            Console.Write($"Is {result.Name} alive? (yes/no)");
            string answer = Console.ReadLine();
            result.Alive = (answer == "yes");

            return result;
        }

        static void WritePlayersToFile(List<Player> players, string filename)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(filename, FileMode.OpenOrCreate)))
            {
                // Write length of list first
                writer.Write(players.Count);

                foreach (Player player in players)
                {
                    writer.Write(player.Name);
                    writer.Write(player.Age);
                    writer.Write(player.Height);
                    writer.Write(player.Alive);
                }
            }
        }

        static List<Player> ReadPlayersFromFile(string filename)
        {
            List<Player> players = new List<Player>();

            using (BinaryReader reader = new BinaryReader(File.Open(filename, FileMode.OpenOrCreate)))
            {
                int numPlayer = reader.ReadInt32();

                for (int i = 0; i < numPlayer; i++)
                {
                    Player p;
                    p.Name = reader.ReadString();
                    p.Age = reader.ReadInt32();
                    p.Height = reader.ReadDouble();
                    p.Alive = reader.ReadBoolean();
                    players.Add(p);
                }
            }

            return players;
        }

        static void PrintPlayer(Player player)
        {
            Console.WriteLine($"{player.Name} [{(player.Alive ? "Alive" : "Dead")}]: Age={player.Age}, Height={player.Height}");
        }

        static void Main(string[] args)
        {
            string filename = "players.bin";

            List<Player> players = new List<Player>();

            //players.Add(InputPlayer());
            //players.Add(InputPlayer());

            //WritePlayersToFile(players, filename);

            players = ReadPlayersFromFile(filename);
            foreach (Player player in players)
            {
                PrintPlayer(player);
            }

            Console.ReadKey();
        }
    }
}
