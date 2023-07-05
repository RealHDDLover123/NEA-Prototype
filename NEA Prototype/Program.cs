using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA_Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool countdown = false;
            bool stopwatch = false;

            Console.WriteLine("Do you wish to have a timer (y/n)?");
            char timerChoice = Console.ReadKey(true).KeyChar;

            if (timerChoice == 'y' || timerChoice == 'Y')
            {
                Console.Write("Do you wish to have either a ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("stopwatch");
                Console.ResetColor();
                Console.Write(" or a ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("countdown");
                Console.ResetColor();
                Console.Write("? To get more information on either, type ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("info");
                Console.ResetColor();

                string whichTimerChoice = Console.ReadLine();

                if (whichTimerChoice == "info".ToUpper())
                {
                    Console.Clear();
                    Console.WriteLine("The stopwatch");
                }

                else if (whichTimerChoice == "s")
                {
                    stopwatch = true;
                }

                else if (whichTimerChoice == "c")
                {
                    countdown = true;
                }

            }

            Console.ReadKey();

        }
    }
}
