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
                Console.Write("? To get more information on either, select ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("info");
                Console.ResetColor();

                Console.WriteLine("");

                Console.WriteLine("  Stopwatch");
                Console.WriteLine("  Countdown");
                Console.WriteLine("  Info");
                Console.WriteLine("  Back");

                Console.CursorTop = 3;
                Console.CursorLeft = 0;
                Console.Write(">");

                int option = 3;
                bool back = false;

                do
                {

                    ConsoleKeyInfo choice = Console.ReadKey(true);

                    if (choice.Key == ConsoleKey.DownArrow && option < 6)
                    {
                        Console.CursorTop = option;
                        Console.CursorLeft = 0;
                        Console.Write(" ");
                        option++;
                        Console.CursorTop = option;
                        Console.CursorLeft = 0;
                        Console.Write(">");
                    }

                    else if (choice.Key == ConsoleKey.UpArrow && option > 3)
                    {
                        Console.CursorTop = option;
                        Console.CursorLeft = 0;
                        Console.Write(" ");
                        option--;
                        Console.CursorTop = option;
                        Console.CursorLeft = 0;
                        Console.Write(">");
                    }

                    else if (choice.Key == ConsoleKey.Enter)
                    {

                        Console.Clear();

                        if (option == 3)
                        {
                            stopwatch = true;
                            Console.WriteLine("stopwatch");
                        }

                        else if (option == 4)
                        {
                            countdown = true;
                            Console.WriteLine("countdown");
                        }

                        else if (option == 5)
                        {
                            Console.WriteLine("info");
                        }

                        else if (option == 6)
                        {
                            Console.WriteLine("back");
                            back = true;
                        }
                    }
                    
                } while (back != true);

            }

            Console.ReadKey();

        }
    }
}
