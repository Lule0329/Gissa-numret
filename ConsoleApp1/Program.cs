using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            gissa();

            Console.WriteLine("Vill du fortsätta (Y/N)");
            string yn = Console.ReadLine();
            if (yn == "y" || yn == "Y")
            {
                Console.Clear();
                gissa();
            }
            else if (yn == "n" || yn == "N")
            {
                Environment.Exit(0);
            }

        }

        public static bool gissa()
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 20);
            bool win = false;

            while (win == false)
            {
                Console.WriteLine("Gissa numret");
                int guess = int.Parse(Console.ReadLine());
                if (guess == number)
                {
                    Console.WriteLine("Du gissade rätt");
                    break;
                }
                else if (number > guess)
                {
                    Console.WriteLine("^");
                }
                else
                {
                    Console.WriteLine("v");
                }
            }
            return win = true;
        }
    }
}
