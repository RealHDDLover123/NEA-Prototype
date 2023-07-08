using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA_Prototype
{
    internal class Program
    {
        static void countdown(int time)
        {
            for (int i = time; i >= 0; i--)
            {
                Console.WriteLine(i + " seconds left");
                System.Threading.Thread.Sleep(1000);
            }
        }

        static void question1()
        {
            Console.WriteLine("Answer is b");
            char userAnswer = Console.ReadKey(true).KeyChar;
        }

        static void question2()
        {
            Console.WriteLine("Answer is a");
            char userAnswer = Console.ReadKey(true).KeyChar;
        }

        static void question3()
        {
            Console.WriteLine("Answer is c");
            char userAnswer = Console.ReadKey(true).KeyChar;
        }

        static void question4()
        {
            Console.WriteLine("Answer is e");
            char userAnswer = Console.ReadKey(true).KeyChar;
        }

        static void question5()
        {
            Console.WriteLine("Answer is d");
            char userAnswer = Console.ReadKey(true).KeyChar;
        }

        static void question6()
        {
            Console.WriteLine("Answer is d");
            char userAnswer = Console.ReadKey(true).KeyChar;
        }

        static void question7()
        {
            Console.WriteLine("Answer is a");
            char userAnswer = Console.ReadKey(true).KeyChar;
        }

        static void question8()
        {
            Console.WriteLine("Answer is b");
            char userAnswer = Console.ReadKey(true).KeyChar;
        }

        static void question9()
        {
            Console.WriteLine("Answer is c");
            char userAnswer = Console.ReadKey(true).KeyChar;
        }

        static void question10()
        {
            Console.WriteLine("Answer is b");
            char userAnswer = Console.ReadKey(true).KeyChar;
        }

        static void Main(string[] args)
        {

            Random rnd = new Random();

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
                        }

                        else if (option == 4)
                        {
                            countdown = true;
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

            Console.WriteLine("Do you want to have a normal sized test or a short test?");
            string testSizeChoice = Console.ReadLine();

            int numOfQuestions = 0;

            if (testSizeChoice == "normal")
            {
                numOfQuestions = 10;
            }

            else if (testSizeChoice == "short")
            {
                numOfQuestions = 5;
            }

            Console.WriteLine("Questions will now be started");

            int nextQuestion = rnd.Next(1, numOfQuestions + 1);

            Console.ReadKey();

        }
    }
}