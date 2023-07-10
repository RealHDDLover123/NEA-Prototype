using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA_Prototype
{
    internal class Program
    {

        static void questionAnswerSelector()
        {        
            char userAnswer = ' ';

            Console.WriteLine("");

            Console.WriteLine("  a");
            Console.WriteLine("  b");
            Console.WriteLine("  c");
            Console.WriteLine("  d");
            Console.WriteLine("  e");

            Console.CursorTop = 3;
            Console.CursorLeft = 0;
            Console.Write(">");

            int option = 3;
            bool back = false;

            do
            {

                ConsoleKeyInfo choice = Console.ReadKey(true);

                if (choice.Key == ConsoleKey.DownArrow && option < 7)
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
                        userAnswer = 'a';
                        back = true;
                    }

                    else if (option == 4)
                    {
                        userAnswer = 'b';
                        back = true;
                    }

                    else if (option == 5)
                    {
                        userAnswer = 'c';
                        back = true;
                    }

                    else if (option == 6)
                    {
                        userAnswer = 'd';
                        back = true;
                    }

                    else if (option == 7)
                    {
                        userAnswer = 'e';
                        back = true;
                    }
                }

            } while (back != true);
        }

        static void question1()
        {
            Console.WriteLine("question 1");
            Console.WriteLine("Answer is b");
            questionAnswerSelector();
        }

        static void question2()
        {
            Console.WriteLine("question 2");
            Console.WriteLine("Answer is a");
            questionAnswerSelector();
        }

        static void question3()
        {
            Console.WriteLine("question 3");
            Console.WriteLine("Answer is c");
            questionAnswerSelector();
        }

        static void question4()
        {
            Console.WriteLine("question 4");
            Console.WriteLine("Answer is e");
            questionAnswerSelector();
        }

        static void question5()
        {
            Console.WriteLine("question 5");
            Console.WriteLine("Answer is d");
            questionAnswerSelector();
        }

        static void question6()
        {
            Console.WriteLine("question 6");
            Console.WriteLine("Answer is d");
            questionAnswerSelector();
        }

        static void question7()
        {
            Console.WriteLine("question 7");
            Console.WriteLine("Answer is a");
            questionAnswerSelector();
        }

        static void question8()
        {
            Console.WriteLine("question 8");
            Console.WriteLine("Answer is b");
            questionAnswerSelector();
        }

        static void question9()
        {
            Console.WriteLine("question 9");
            Console.WriteLine("Answer is c");
            questionAnswerSelector();
        }

        static void question10()
        {
            Console.WriteLine("question 10");
            Console.WriteLine("Answer is b");
            questionAnswerSelector();
        }


        static void printQuestions(int numOfQuestions, bool finishedTest)
        {
            Random rnd = new Random();
            
            List<int> listOfUniqueNumbers = new List<int>();

            while (listOfUniqueNumbers.Count != numOfQuestions)
            {
                for (int i = 0; i < numOfQuestions + 1; i++)
                {
                    int chosenQuestionNumber = rnd.Next(1, 11 /* this number should be the maximum possible amount of questions + 1 */);

                    if (!listOfUniqueNumbers.Contains(chosenQuestionNumber))
                    {
                        listOfUniqueNumbers.Add(chosenQuestionNumber);
                    }
                }
            }

            for (int i = 0; i < listOfUniqueNumbers.Count; i++)
            {
                int chosenQuestion = listOfUniqueNumbers[i];

                switch (chosenQuestion)
                {
                    case 1:
                        question1();
                        break;

                    case 2:
                        question2();
                        break;

                    case 3:
                        question3();
                        break;

                    case 4:
                        question4();
                        break;

                    case 5:
                        question5();
                        break;

                    case 6:
                        question6();
                        break;

                    case 7:
                        question7();
                        break;

                    case 8:
                        question8();
                        break;

                    case 9:
                        question9();
                        break;

                    case 10:
                        question10();
                        break;

                    default:
                        break;
                }

            }

            Console.WriteLine("End of questions");
            finishedTest = true;
        }

        static void Main(string[] args)
        {

            Stopwatch Stopwatch = new Stopwatch();

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
                bool backTimerChoice = false;

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
                            backTimerChoice = true;
                        }

                        else if (option == 4)
                        {
                            countdown = true;
                            backTimerChoice = true;
                        }

                        else if (option == 5)
                        {
                            Console.WriteLine("info");
                            Console.ReadKey();
                            backTimerChoice = true;
                        }

                        else if (option == 6)
                        {
                            Console.WriteLine("back");
                            backTimerChoice = true;
                        }
                    }

                } while (backTimerChoice != true);

            }

            Console.Clear();

            Console.WriteLine("Do you want to have a normal sized test or a short test?");

            int numOfQuestions = 0;

            Console.WriteLine("");

            Console.WriteLine("  normal");
            Console.WriteLine("  short");

            Console.CursorTop = 2;
            Console.CursorLeft = 0;
            Console.Write(">");

            int testSizeChoice = 2;
            bool backQuestionSize = false;

            do
            {

                ConsoleKeyInfo choice = Console.ReadKey(true);

                if (choice.Key == ConsoleKey.DownArrow && testSizeChoice < 3)
                {
                    Console.CursorTop = testSizeChoice;
                    Console.CursorLeft = 0;
                    Console.Write(" ");
                    testSizeChoice++;
                    Console.CursorTop = testSizeChoice;
                    Console.CursorLeft = 0;
                    Console.Write(">");
                }

                else if (choice.Key == ConsoleKey.UpArrow && testSizeChoice > 2)
                {
                    Console.CursorTop = testSizeChoice;
                    Console.CursorLeft = 0;
                    Console.Write(" ");
                    testSizeChoice--;
                    Console.CursorTop = testSizeChoice;
                    Console.CursorLeft = 0;
                    Console.Write(">");
                }

                else if (choice.Key == ConsoleKey.Enter)
                {

                    Console.Clear();

                    if (testSizeChoice == 2)
                    {
                        numOfQuestions = 10;
                        backQuestionSize = true;
                    }

                    else if (testSizeChoice == 3)
                    {
                        numOfQuestions = 5;
                        backQuestionSize = true;
                    }
                }

            } while (backQuestionSize != true);

            Console.WriteLine("Questions will now be started");

            Console.ReadKey();

            bool finishedTest = false;

            Console.Clear();
            
            //stops here for some reason

            if (countdown == true || stopwatch == true)
            {
                Stopwatch.Start();
            }

            printQuestions(numOfQuestions, finishedTest);

            if (stopwatch == true)
            {
                Stopwatch.Stop();

                TimeSpan elapsedTimeStopwatch = Stopwatch.Elapsed;

                string time = String.Format("{0:00}:{1:00}", elapsedTimeStopwatch.Minutes, elapsedTimeStopwatch.Seconds);

                Console.WriteLine("Your time was " + time);
            }

            else if (countdown == true)
            {
                Stopwatch.Stop();

                TimeSpan elapsedTimeCountdown = Stopwatch.Elapsed;

                TimeSpan countdownTime = TimeSpan.FromMinutes(10) - elapsedTimeCountdown;

                Console.WriteLine("Your time taken was " + countdownTime);
            }

            Console.ReadKey();

        }
    }
}