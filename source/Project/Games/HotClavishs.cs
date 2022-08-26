using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Project.Games
{
    public class HotClavishs
    {
        private List<string> alphabets = new List<string>();
        private string Uzun = "*********";
        private string Chap = "* --";
        private string Ong = "-- *";
        private int Exit = 0;
        private int Score = 0;
        private Thread one;
        private Thread two;

        public HotClavishs()
        {
            one = new(Go);
            two = new(CheckContraint);
        }

        public void Menu()
        {    
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

            Console.WriteLine("********************************************************Настарт******************************************************");
            Thread.Sleep(500);
            Console.WriteLine("*******************************************************Внимание*******************************************************");
            Thread.Sleep(500);
            Console.WriteLine("********************************************************Старт*********************************************************");
            Thread.Sleep(500);

            one.Start();
            two.Start();
        }

        public void Go()
        {
            Random random = new();
            int z = 1000;

            while (true)
            {
                if (Exit == 1)
                {
                    Console.WriteLine("*****************************************************Вы Проиграли******************************************************");
                    Console.WriteLine($"\t\t\t\t  ********************Рекорд:{Score}********************");
                    Console.ResetColor();
                    break;
                }

                switch (random.Next(1, 26))
                {
                    case 1: 
                        Console.WriteLine($"{Uzun}\n{Chap}Q{Ong}\n{Uzun}");
                        Console.ForegroundColor = ConsoleColor.Red;
                        alphabets.Add("Q"); break;
                    case 2:
                        Console.WriteLine($" \t{Uzun}\n \t{Chap}W{Ong}\n \t{Uzun}");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        alphabets.Add("W"); break;
                    case 3:
                        Console.WriteLine($" \t\t{Uzun}\n \t\t{Chap}E{Ong}\n\t\t{Uzun}");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        alphabets.Add("E"); break;
                    case 4:
                        Console.WriteLine($" \t\t\t{Uzun}\n \t\t\t{Chap}R{Ong}\n\t\t\t{Uzun}");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        alphabets.Add("R"); break;
                    case 5:
                        Console.WriteLine($" \t\t\t\t{Uzun}\n \t\t\t\t{Chap}T{Ong}\n\t\t\t\t{Uzun}");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        alphabets.Add("T"); break;
                    case 6:
                        Console.WriteLine($" \t\t\t\t\t{Uzun}\n \t\t\t\t\t{Chap}Y{Ong}\n\t\t\t\t\t{Uzun}");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        alphabets.Add("Y"); break;
                    case 7:
                        Console.WriteLine($" \t\t\t\t\t\t{Uzun}\n \t\t\t\t\t\t{Chap}U{Ong}\n\t\t\t\t\t\t{Uzun}");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        alphabets.Add("U"); break;
                    case 8:
                        Console.WriteLine($" \t\t\t\t\t\t\t{Uzun}\n \t\t\t\t\t\t\t{Chap}I{Ong}\n\t\t\t\t\t\t\t{Uzun}");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        alphabets.Add("I"); break;
                    case 9:
                        Console.WriteLine($" \t\t\t\t\t\t\t\t{Uzun}\n \t\t\t\t\t\t\t\t{Chap}O{Ong}\n\t\t\t\t\t\t\t\t{Uzun}");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        alphabets.Add("O"); break;
                    case 10:
                        Console.WriteLine($" \t\t\t\t\t\t\t\t\t{Uzun}\n \t\t\t\t\t\t\t\t\t{Chap}P{Ong}\n\t\t\t\t\t\t\t\t\t{Uzun}");
                        Console.ForegroundColor = ConsoleColor.Red;
                        alphabets.Add("P"); break;
                    case 11:
                        Console.WriteLine($"{Uzun}\n{Chap}A{Ong}\n{Uzun}");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        alphabets.Add("A"); break;
                    case 12:
                        Console.WriteLine($" \t{Uzun}\n \t{Chap}S{Ong}\n \t{Uzun}");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        alphabets.Add("S"); break;
                    case 13:
                        Console.WriteLine($" \t\t{Uzun}\n \t\t{Chap}D{Ong}\n \t\t{Uzun}");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        alphabets.Add("D"); break;
                    case 14:
                        Console.WriteLine($" \t\t\t{Uzun}\n \t\t\t{Chap}F{Ong}\n \t\t\t{Uzun}");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        alphabets.Add("F"); break;
                    case 15:
                        Console.WriteLine($" \t\t\t\t{Uzun}\n \t\t\t\t{Chap}G{Ong}\n \t\t\t\t{Uzun}");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        alphabets.Add("G"); break;
                    case 16:
                        Console.WriteLine($" \t\t\t\t\t{Uzun}\n \t\t\t\t\t{Chap}H{Ong}\n \t\t\t\t\t{Uzun}");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        alphabets.Add("H"); break;
                    case 17:
                        Console.WriteLine($" \t\t\t\t\t\t{Uzun}\n \t\t\t\t\t\t{Chap}J{Ong}\n \t\t\t\t\t\t{Uzun}");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        alphabets.Add("J"); break;
                    case 18:
                        Console.WriteLine($" \t\t\t\t\t\t\t{Uzun}\n \t\t\t\t\t\t\t{Chap}K{Ong}\n \t\t\t\t\t\t\t{Uzun}");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        alphabets.Add("K"); break;
                    case 19:
                        Console.WriteLine($" \t\t\t\t\t\t\t\t{Uzun}\n \t\t\t\t\t\t\t\t{Chap}L{Ong}\n \t\t\t\t\t\t\t\t{Uzun}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        alphabets.Add("L"); break;
                    case 20:
                        Console.WriteLine($"{Uzun}\n{Chap}Z{Ong}\n{Uzun}");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        alphabets.Add("Z"); break;
                    case 21:
                        Console.WriteLine($" \t{Uzun}\n \t{Chap}X{Ong}\n \t{Uzun}");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        alphabets.Add("X"); break;
                    case 22:
                        Console.WriteLine($" \t\t{Uzun}\n \t\t{Chap}C{Ong}\n \t\t{Uzun}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        alphabets.Add("C"); break;
                    case 23:
                        Console.WriteLine($" \t\t\t{Uzun}\n \t\t\t{Chap}V{Ong}\n \t\t\t{Uzun}");
                        Console.ForegroundColor = ConsoleColor.Red;
                        alphabets.Add("V"); break;
                    case 24:
                        Console.WriteLine($" \t\t\t\t{Uzun}\n \t\t\t\t{Chap}B{Ong}\n \t\t\t\t{Uzun}");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        alphabets.Add("B"); break;
                    case 25:
                        Console.WriteLine($" \t\t\t\t\t{Uzun}\n \t\t\t\t\t{Chap}N{Ong}\n \t\t\t\t\t{Uzun}");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        alphabets.Add("N"); break;
                    case 26:
                        Console.WriteLine($" \t\t\t\t\t\t{Uzun}\n \t\t\t\t\t\t{Chap}M{Ong}\n \t\t\t\t\t\t{Uzun}");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        alphabets.Add("M"); break;
                }


                Thread.Sleep(z--);
            }

           
        }

        private void CheckContraint()
        {
            try
            {
                while (true)
                {
                    string H = Console.ReadKey().Key.ToString();

                    if (H == alphabets[0])
                    {
                        Score++;
                        alphabets.RemoveAt(0);
                        continue;
                    }
                    else
                    {
                        Exit = 1;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                Exit = 1;
            }


        }

    }
}
