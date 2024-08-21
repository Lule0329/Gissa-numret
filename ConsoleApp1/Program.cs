using Microsoft.Win32.SafeHandles;
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
        }

        public static bool gissa()
        {
            int diff = 20;
            Console.WriteLine("Välj svårighetsgrad: (E/M/H)");
            string difficulty = Console.ReadLine();
            
            if (difficulty == "e" || difficulty == "E")
            {
                diff = 20;
            }
            else if (difficulty == "m" || difficulty == "M")
            {
                diff = 50;
            }
            else if (difficulty == "h" || difficulty == "H")
            {
                diff = 100;
            }
            else if (difficulty == "superdupersecret")
            {
                Console.WriteLine("Skriv in eget nummer över 0");
                diff = int.Parse(Console.ReadLine());
            }

            Random rnd = new Random();
            int number = rnd.Next(0, diff);
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

            if (diff > 1000)
            {
                Console.WriteLine("hooray!!");
            }

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

            return win = true;
        }
    }
}
