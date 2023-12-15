using System;
using System.IO;

namespace ConsoleApp3
{
    internal class Program
    {
        private static string[,] grid = new string[7, 7];
        private static string[] squares = new string[49];
        private static int score;
        private static int bank;
        private static bool shield;
        private static bool mirror;
        private static int round;
        private static bool minimised = false;
        private static string lastGridItem = "";

        public static void Reset()
        {
            shield = false;
            mirror = false;
            round = 0;
            for (var i = 0; i <= 6; i++)
            {
                for (var j = 0; j <= 6; j++)
                    grid[i, j] = "       ";
            }
            squares[0] = " Thief ";
            squares[1] = " Bomb  ";
            squares[2] = " Knife ";
            squares[3] = "Present";
            squares[4] = " Death ";
            squares[5] = " Swap  ";
            squares[6] = "Choose ";
            squares[7] = "Shield ";
            squares[8] = "Mirror ";
            squares[9] = "  x2   ";
            squares[10] = " Bank  ";
            squares[11] = " 5000  ";
            squares[12] = " 3000  ";
            squares[13] = " 3000  ";
            for (var i = 14; i <= 23; i++)
                squares[i] = " 1000  ";
            for (int i = 24; i <= 48; i++)
                squares[i] = "  200  ";
        }

        public static void Print()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("   |   0   |   1   |   2   |   3   |   4   |   5   |   6   |");
            for (var i = 0; i <= 6; i++)
            {
                Console.WriteLine();
                Console.WriteLine("---+-------+-------+-------+-------+-------+-------+-------+");
                Console.Write(" " + i + " ");
                Console.Write("|");
                for (var j = 0; j <= 6; j++)
                {
                    if (minimised & grid[i, j] != "       ")
                        Console.Write("  ???  |");
                    else
                        Console.Write(grid[i, j] + "|");
                }
            }
            Console.WriteLine("\n---+-------+-------+-------+-------+-------+-------+-------+");
            Console.WriteLine();
            if (round != 0 & !minimised)
            {
                Console.Write("Current score: ");
                if (score == 0)
                    ColourWriteLine(score.ToString(), ConsoleColor.DarkGray);
                else
                    ColourWriteLine(score.ToString(), ConsoleColor.Yellow);
                Console.Write("Banked: ");
                if (bank == 0)
                    ColourWriteLine(bank.ToString(), ConsoleColor.DarkGray);
                else
                    ColourWriteLine(bank.ToString(), ConsoleColor.Yellow);

                if (shield)
                    ColourWriteLine("Shield ready to block!", ConsoleColor.Green);
                if (mirror)
                    ColourWriteLine("Mirror ready to reflect!", ConsoleColor.Cyan);
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public static void ColourWriteLine(string text, ConsoleColor colour)
        {
            var prevColour = Console.ForegroundColor;

            Console.ForegroundColor = colour;

            Console.WriteLine(text);

            Console.ForegroundColor = prevColour;
        }

        public static void RandomGrid()
        {
            Random r = new Random();
            int i;
            int j;
            for (var k = 0; k <= 23; k++)
            {
                do
                {
                    i = r.Next(0, 6 + 1);
                    j = r.Next(0, 6 + 1);
                }
                while (!(grid[i, j] == "       "));
                grid[i, j] = squares[k];
            }

            for (i = 0; i <= 6; i++)
            {
                for (j = 0; j <= 6; j++)
                {
                    if (grid[i, j] == "       ")
                        grid[i, j] = "  200  ";
                }
            }
        }

        public static void PlayGame(int row, int col)
        {
            switch (grid[row, col])
            {
                case " Thief ":
                    {
                        ColourWriteLine("Choose someone to steal points from", ConsoleColor.DarkGreen);
                        ColourWriteLine("You get half of their points", ConsoleColor.DarkGreen);
                        string temp;
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("How many points did you get?");
                            Console.ForegroundColor = ConsoleColor.White;
                            temp = Console.ReadLine();
                        }
                        while (!int.TryParse(temp, out _));
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        score += System.Convert.ToInt32(temp);
                        break;
                    }

                case " Bomb  ":
                    {
                        ColourWriteLine("Choose someone to bomb", ConsoleColor.DarkGreen);
                        ColourWriteLine("Everyone on their row gets hit", ConsoleColor.DarkGreen);
                        ColourWriteLine("Press Enter to continue...", ConsoleColor.White);
                        while (Console.ReadKey(true).Key != ConsoleKey.Enter)
                        {
                        }

                        break;
                    }

                case " Knife ":
                    {
                        ColourWriteLine("Choose someone to kill", ConsoleColor.DarkGreen);
                        ColourWriteLine("Press Enter to continue", ConsoleColor.White);
                        while (Console.ReadKey(true).Key != ConsoleKey.Enter)
                        {
                        }

                        break;
                    }

                case "Present":
                    {
                        ColourWriteLine("Choose someone to give a present to!", ConsoleColor.Yellow);
                        ColourWriteLine("Press Enter to continue", ConsoleColor.White);
                        while (Console.ReadKey(true).Key != ConsoleKey.Enter)
                        {
                        }

                        break;
                    }

                case " Death ":
                    {
                        ColourWriteLine("You died!", ConsoleColor.Red);
                        ColourWriteLine("Your score is now set to 0", ConsoleColor.Red);
                        System.Threading.Thread.Sleep(2000);
                        score = 0;
                        break;
                    }

                case " Swap  ":
                    {
                        ColourWriteLine("You get to swap with someone!", ConsoleColor.DarkGreen);
                        ColourWriteLine("Your current score is: " + score, ConsoleColor.DarkGreen);
                        ColourWriteLine("What is your new score?", ConsoleColor.Yellow);
                        Console.ForegroundColor = ConsoleColor.White;
                        string tempscore = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        while (!int.TryParse(tempscore, out _))
                        {
                            ColourWriteLine("Invalid input, try again", ConsoleColor.Red);
                            ColourWriteLine("What is your new score?", ConsoleColor.Yellow);
                            Console.ForegroundColor = ConsoleColor.White;
                            tempscore = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.Magenta;
                        }
                        score = System.Convert.ToInt32(tempscore);
                        break;
                    }

                case "Choose ":
                    {
                        ColourWriteLine("You choose the next space!", ConsoleColor.DarkGreen);
                        ColourWriteLine("Press Enter to continue", ConsoleColor.White);
                        while (Console.ReadKey(true).Key != ConsoleKey.Enter)
                        {
                        }

                        break;
                    }

                case "Shield ":
                    {
                        shield = true;
                        ColourWriteLine("You acquired a shield!", ConsoleColor.Green);
                        System.Threading.Thread.Sleep(2000);
                        break;
                    }

                case "Mirror ":
                    {
                        mirror = true;
                        ColourWriteLine("You acquired a mirror!", ConsoleColor.Cyan);
                        System.Threading.Thread.Sleep(2000);
                        break;
                    }

                case "  x2   ":
                    {
                        score *= 2;
                        ColourWriteLine("You doubled your score!", ConsoleColor.Yellow);
                        System.Threading.Thread.Sleep(2000);
                        break;
                    }

                case " Bank  ":
                    {
                        bank += score;
                        score = 0;
                        ColourWriteLine("You have safely stored your points in the bank!", ConsoleColor.Yellow);
                        System.Threading.Thread.Sleep(2000);
                        break;
                    }

                case " 5000  ":
                    {
                        Console.Write("You gained ");
                        ColourWriteLine("5000 pts", ConsoleColor.Yellow);
                        System.Threading.Thread.Sleep(2000);
                        score += 5000;
                        break;
                    }

                case " 3000  ":
                    {
                        Console.Write("You gained ");
                        ColourWriteLine("3000 pts", ConsoleColor.Yellow);
                        System.Threading.Thread.Sleep(2000);
                        score += 3000;
                        break;
                    }

                case " 1000  ":
                    {
                        Console.Write("You gained ");
                        ColourWriteLine("1000 pts", ConsoleColor.Yellow);
                        System.Threading.Thread.Sleep(2000);
                        score += 1000;
                        break;
                    }

                case "  200  ":
                    {
                        Console.Write("You gained ");
                        ColourWriteLine("200 pts", ConsoleColor.Yellow);
                        System.Threading.Thread.Sleep(2000);
                        score += 200;
                        break;
                    }
            }
            lastGridItem = grid[row, col];
            grid[row, col] = "       ";
        }

        public static void Main()
        {
            int row = 0;
            int col = 0;
            string temp = "";
            string cheatCheck = "";
            try
            {
                Console.WindowHeight = 40;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Font size too big");
            }

            Reset();
            RandomGrid();

            while (round < 49)
            {
                temp = "";

                Print();
                if (round != 0)
                {
                    string toPrint = "Last round - (row: " + row + ", col: " + col + ")";
                    if (!minimised)
                        toPrint += $" --> '{lastGridItem.Trim(' ')}'";
                    ColourWriteLine(toPrint, ConsoleColor.Gray);
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("What next?");
                if (minimised)
                    Console.WriteLine("[0]: Show grid, money and items");
                else
                    Console.WriteLine("[0]: Hide grid, money and items");
                Console.WriteLine("[1]: Enter a grid coordinate");
                Console.WriteLine("[2]: A thief stole from me");
                Console.WriteLine("[3]: I got knifed");
                Console.WriteLine("[4]: Someone threw a bomb at me");
                Console.WriteLine("[5]: My row was bombed (bomb not thrown at me directly)");
                Console.WriteLine("[6]: Someone swapped with me");
                Console.WriteLine("[7]: I received a present");
                string choice = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                cheatCheck += choice;
                cheatCheck += " ";
                switch (choice)
                {
                    case "0":
                        {
                            minimised = !minimised;
                            break;
                        }

                    case "1":
                        {
                            int newRow = -1, newCol = -1;
                            bool cancel = false;
                            Console.WriteLine("This is a new round! (type 'cancel' to go back)");
                            do
                            {
                                do
                                {
                                    if (temp == "cancel")
                                    {
                                        cancel = true;
                                        break;
                                    }

                                    Console.Write("Enter a ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("ROW: ");
                                    temp = Console.ReadLine();
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                }
                                while (!int.TryParse(temp, out _));
                                if (cancel) break;
                                newRow = System.Convert.ToInt32(temp);
                            }
                            while (!(newRow >= 0 & newRow <= 6));
                            if (cancel) break;

                            do
                            {
                                do
                                {
                                    if (temp == "cancel")
                                    {
                                        cancel = true;
                                        break;
                                    }

                                    Console.Write("Enter a ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("COLUMN: ");
                                    temp = Console.ReadLine();
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                }
                                while (!int.TryParse(temp, out _));
                                if (cancel) break;
                                newCol = System.Convert.ToInt32(temp);
                            }
                            while (!(newCol >= 0 & newCol <= 6));
                            if (cancel) break;

                            if (grid[newRow, newCol] == "       ")
                            {
                                ColourWriteLine("Error!! This space has already been used", ConsoleColor.Red);
                                System.Threading.Thread.Sleep(2000);
                            }
                            else
                            {
                                row = newRow;
                                col = newCol;
                                PlayGame(row, col);
                                round += 1;
                            }

                            break;
                        }

                    case "2":
                        {
                            if (shield == true)
                            {
                                Console.WriteLine("Would you Like to use your shield? y/n");
                                string used = Console.ReadLine().ToLower();
                                if (used == "y")
                                {
                                    ColourWriteLine("You blocked the attack, but your shield broke!", ConsoleColor.Green);
                                    System.Threading.Thread.Sleep(2000);
                                    shield = false;
                                }
                                else if (mirror == true)
                                {
                                    Console.WriteLine("Would you Like to use your mirror? y/n");
                                    used = Console.ReadLine().ToLower();
                                    if (used == "y")
                                    {
                                        mirror = false;
                                        ColourWriteLine("You deflect it back at the attacker, but your mirror broke!", ConsoleColor.Cyan);
                                        System.Threading.Thread.Sleep(2000);
                                    }
                                    else
                                    {
                                        ColourWriteLine("Someone stole half your points!", ConsoleColor.Red);
                                        ColourWriteLine("They stole " + score / (double)2 + "pts", ConsoleColor.Red);
                                        Console.WriteLine("Press enter to continue....");
                                        while (Console.ReadKey(true).Key != ConsoleKey.Enter)
                                        {
                                        }
                                        score /= 2;
                                    }
                                }
                                else
                                {
                                    ColourWriteLine("Someone stole half your points!", ConsoleColor.Red);
                                    ColourWriteLine("They stole " + score / (double)2 + "pts", ConsoleColor.Red);
                                    Console.WriteLine("Press enter to continue....");
                                    while (Console.ReadKey(true).Key != ConsoleKey.Enter)
                                    {
                                    }
                                    score /= 2;
                                }
                            }
                            else if (mirror == true)
                            {
                                Console.WriteLine("Would you Like to use your mirror? y/n");
                                string used = Console.ReadLine().ToLower();
                                if (used == "y")
                                {
                                    ColourWriteLine("You deflect it back at the attacker, but your mirror broke!", ConsoleColor.Cyan);
                                    System.Threading.Thread.Sleep(2000);
                                    mirror = false;
                                }
                                else
                                {
                                    ColourWriteLine("Someone stole half your points!", ConsoleColor.Red);
                                    ColourWriteLine("They stole " + score / (double)2 + "pts", ConsoleColor.Red);
                                    Console.WriteLine("Press enter to continue....");
                                    while (Console.ReadKey(true).Key != ConsoleKey.Enter)
                                    {
                                    }
                                    score /= 2;
                                }
                            }
                            else
                            {
                                ColourWriteLine("Someone stole half your points!", ConsoleColor.Red);
                                ColourWriteLine("They stole " + score / (double)2 + "pts", ConsoleColor.Red);
                                Console.WriteLine("Press enter to continue....");
                                while (Console.ReadKey(true).Key != ConsoleKey.Enter)
                                {
                                }
                                score /= 2;
                            }

                            break;
                        }

                    case "3":
                        {
                            if (shield == true)
                            {
                                Console.WriteLine("Would you Like to use your shield? y/n");
                                string used = Console.ReadLine().ToLower();
                                if (used == "y")
                                {
                                    shield = false;
                                    ColourWriteLine("You blocked the attack, but your shield broke!", ConsoleColor.Green);
                                    System.Threading.Thread.Sleep(2000);
                                }
                                else if (mirror == true)
                                {
                                    Console.WriteLine("Would you Like to use your mirror? y/n");
                                    used = Console.ReadLine().ToLower();
                                    if (used == "y")
                                    {
                                        mirror = false;
                                        ColourWriteLine("You deflect it back at the attacker, but your mirror broke!", ConsoleColor.Cyan);
                                        System.Threading.Thread.Sleep(2000);
                                    }
                                    else
                                    {
                                        score = 0;
                                        ColourWriteLine("You lost all your points!", ConsoleColor.Red);
                                        System.Threading.Thread.Sleep(2000);
                                    }
                                }
                                else
                                {
                                    score = 0;
                                    ColourWriteLine("You lost all your points!", ConsoleColor.Red);
                                    System.Threading.Thread.Sleep(2000);
                                }
                            }
                            else if (mirror == true)
                            {
                                Console.WriteLine("Would you Like to use your mirror? y/n");
                                string used = Console.ReadLine().ToLower();
                                if (used == "y")
                                {
                                    mirror = false;
                                    ColourWriteLine("You deflect it back at the attacker, but your mirror broke!", ConsoleColor.Cyan);
                                    System.Threading.Thread.Sleep(2000);
                                }
                                else
                                {
                                    score = 0;
                                    ColourWriteLine("You lost all your points!", ConsoleColor.Red);
                                    System.Threading.Thread.Sleep(2000);
                                }
                            }
                            else
                            {
                                score = 0;
                                ColourWriteLine("You lost all your points!", ConsoleColor.Red);
                                System.Threading.Thread.Sleep(2000);
                            }

                            break;
                        }

                    case "4":
                        {
                            if (shield == true)
                            {
                                Console.WriteLine("Would you Like to use your shield? y/n");
                                string used = Console.ReadLine().ToLower();
                                if (used == "y")
                                {
                                    ColourWriteLine("You blocked the attack, but your shield broke!", ConsoleColor.Green);
                                    System.Threading.Thread.Sleep(2000);
                                    shield = false;
                                }
                                else if (mirror == true)
                                {
                                    Console.WriteLine("Would you Like to use your mirror? y/n");
                                    used = Console.ReadLine().ToLower();
                                    if (used == "y")
                                    {
                                        mirror = false;
                                        ColourWriteLine("You deflect it back at the attacker, but your mirror broke!", ConsoleColor.Cyan);
                                        System.Threading.Thread.Sleep(2000);
                                    }
                                    else
                                    {
                                        score = 0;
                                        ColourWriteLine("You lost all your points!", ConsoleColor.Red);
                                        ColourWriteLine("Everyone else on your row got bombed too!", ConsoleColor.Red);
                                        System.Threading.Thread.Sleep(2000);
                                    }
                                }
                                else
                                {
                                    score = 0;
                                    ColourWriteLine("You lost all your points!", ConsoleColor.Red);
                                    ColourWriteLine("Everyone else on your row got bombed too!", ConsoleColor.Red);
                                    System.Threading.Thread.Sleep(2000);
                                }
                            }
                            else if (mirror == true)
                            {
                                Console.WriteLine("Would you Like to use your mirror? y/n");
                                string used = Console.ReadLine().ToLower();
                                if (used == "y")
                                {
                                    mirror = false;
                                    ColourWriteLine("You deflect it back at the attacker, but your mirror broke!", ConsoleColor.Cyan);
                                    System.Threading.Thread.Sleep(2000);
                                }
                                else
                                {
                                    score = 0;
                                    ColourWriteLine("You lost all your points!", ConsoleColor.Red);
                                    ColourWriteLine("Everyone else on your row got bombed too!", ConsoleColor.Red);
                                    System.Threading.Thread.Sleep(2000);
                                }
                            }
                            else
                            {
                                score = 0;
                                ColourWriteLine("You lost all your points!", ConsoleColor.Red);
                                ColourWriteLine("Everyone else on your row got bombed too!", ConsoleColor.Red);
                                System.Threading.Thread.Sleep(2000);
                            }

                            break;
                        }

                    case "5":
                        {
                            score = score / 2;
                            ColourWriteLine("You lost half your points!", ConsoleColor.Red);
                            System.Threading.Thread.Sleep(2000);
                            break;
                        }

                    case "6":
                        {
                            Console.WriteLine("Your current score is " + score);
                            if (mirror)
                                Console.WriteLine("Your mirror isn't going to help here\n");
                            if (shield == true)
                            {
                                Console.WriteLine("Would you Like to use your shield? y/n");
                                string used = Console.ReadLine().ToLower();
                                if (used == "y")
                                {
                                    ColourWriteLine("You blocked the attack, but your shield broke!", ConsoleColor.Green);
                                    System.Threading.Thread.Sleep(2000);
                                    shield = false;
                                }
                                else
                                {
                                    Console.Write("What is your new score? ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    score = int.Parse(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                }
                            }
                            else
                            {
                                Console.Write("What is your new score? ");
                                Console.ForegroundColor = ConsoleColor.White;
                                bool done;
                                do
                                {
                                    done = true;
                                    try
                                    {
                                        string answer = Console.ReadLine();
                                        if (answer.ToLower() == "cancel")
                                        {
                                        }
                                        else
                                            score = int.Parse(answer);
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Invalid input");
                                        done = false;
                                    }
                                }
                                while (!done == true);


                                Console.ForegroundColor = ConsoleColor.Magenta;
                            }

                            break;
                        }

                    case "7":
                        {
                            score += 1000;
                            ColourWriteLine("Someone gave you 1000pts!", ConsoleColor.Yellow);
                            System.Threading.Thread.Sleep(2000);
                            break;
                        }
                }
            }
            Console.Clear();
            ColourWriteLine("END OF GAME!! YOUR FINAL SCORE IS " + (score + bank), ConsoleColor.Yellow);
            using (StreamWriter writer = new StreamWriter("HighScores.txt", true))
            {
                writer.WriteLine(score);
                writer.WriteLine("cheat checker: " + cheatCheck);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"
                     .ed```` ```$$$$be.
                   -`           ^``**$$$e.
                 .`                   '$$$c
                /                      `4$$b
               d  3                      $$$$
               $  *                   .$$$$$$
              .$  ^c           $$$$$e$$$$$$$$.
              d$L  4.         4$$$$$$$$$$$$$$b
              $$$$b ^ceeeee.  4$$ECL.F*$$$$$$$
  e$`` = .      $$$$P d$$$$F $ $$$$$$$$$- $$$$$$
 z$$b. ^c     3$$$F `$$$$b   $`$$$$$$$  $$$$*`      .=``$c
4$$$$L        $$P`  `$$b   .$ $$$$$...e$$        .=  e$$$.
^*$$$$$c  %..   *c    ..    $$ 3$$$$$$$$$$eF     zP  d$$$$$
  `**$$$ec   `   %ce``    $$$  $$$$$$$$$$*    .r` =$$$$P``
        `*$b.  `c  *$e.    *** d$$$$$`L$$    .d`  e$$***`
          ^*$$c ^$c $$$      4J$$$$$% $$$ .e*`.eeP`
             `$$$$$$``$=e....$*$$**$cz$$` `..d$*`
               `*$$$  *=%4.$ L L$ P3$$$F $$$P`
                  `$   `%*ebJLzb$e$$$$$b $P`
                    %..      4$$$$$$$$$$ `
                     $$$e   z$$$$$$$$$$%
                      `*$c  `$$$$$$$P`
                       .```*$$$$$$$$bc
                    .-`    .$***$$$```*e.
                 .-`    .e$`     `*$c  ^*b.
          .=*````    .e$*`          `*bc  `*$e..
        .$`        .z*`               ^*$e.   `*****e.
        $$ee$c   .d`                     `*$.        3.
        ^*$E`)$..$`                         *   .ee==d%
           $.d$$$*                           *  J$$$e*
            `````                              `$$$`
");
            while (true) Console.ReadKey(true);
        }
    }
}