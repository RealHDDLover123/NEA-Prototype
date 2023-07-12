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
        static char questionAnswerSelector(char userAnswer)
        {

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

            while (back != true)
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
                    }

                    else if (option == 4)
                    {
                        userAnswer = 'b';
                    }

                    else if (option == 5)
                    {
                        userAnswer = 'c';
                    }

                    else if (option == 6)
                    {
                        userAnswer = 'd';
                    }

                    else if (option == 7)
                    {
                        userAnswer = 'e';
                    }

                    back = true;

                }
            }

            return userAnswer;

        }

        static int question1(int correct, char userAnswer)
        {
            Console.WriteLine("question 1");
            Console.WriteLine("Answer is b");
            userAnswer = questionAnswerSelector(userAnswer);

            if (userAnswer == 'b')
            {
                correct++;
            }

            return correct;

        }

        static int question2(int correct, char userAnswer)
        {
            Console.WriteLine("question 2");
            Console.WriteLine("Answer is a");
            userAnswer = questionAnswerSelector(userAnswer);

            if (userAnswer == 'a')
            {
                correct++;
            }

            return correct;

        }

        static int question3(int correct, char userAnswer)
        {
            Console.WriteLine("question 3");
            Console.WriteLine("Answer is c");
            userAnswer = questionAnswerSelector(userAnswer);

            if (userAnswer == 'c')
            {
                correct++;
            }

            return correct;

        }

        static int question4(int correct, char userAnswer)
        {
            Console.WriteLine("question 4");
            Console.WriteLine("Answer is e");
            userAnswer = questionAnswerSelector(userAnswer);

            if (userAnswer == 'e')
            {
                correct++;
            }

            return correct;

        }

        static int question5(int correct, char userAnswer)
        {
            Console.WriteLine("question 5");
            Console.WriteLine("Answer is d");
            userAnswer = questionAnswerSelector(userAnswer);

            if (userAnswer == 'd')
            {
                correct++;
            }

            return correct;

        }

        static int question6(int correct, char userAnswer)
        {
            Console.WriteLine("question 6");
            Console.WriteLine("Answer is d");
            userAnswer = questionAnswerSelector(userAnswer);

            if (userAnswer == 'd')
            {
                correct++;
            }

            return correct;

        }

        static int question7(int correct, char userAnswer)
        {
            Console.WriteLine("question 7");
            Console.WriteLine("Answer is a");
            userAnswer = questionAnswerSelector(userAnswer);

            if (userAnswer == 'a')
            {
                correct++;
            }

            return correct;

        }

        static int question8(int correct, char userAnswer)
        {
            Console.WriteLine("question 8");
            Console.WriteLine("Answer is b");
            userAnswer = questionAnswerSelector(userAnswer);

            if (userAnswer == 'b')
            {
                correct++;
            }

            return correct;

        }

        static int question9(int correct, char userAnswer)
        {
            Console.WriteLine("question 9");
            Console.WriteLine("Answer is c");
            userAnswer = questionAnswerSelector(userAnswer);

            if (userAnswer == 'c')
            {
                correct++;
            }

            return correct;

        }

        static int question10(int correct, char userAnswer)
        {
            Console.WriteLine("question 10");
            Console.WriteLine("Answer is b");
            userAnswer = questionAnswerSelector(userAnswer);

            if (userAnswer == 'b')
            {
                correct++;
            }

            return correct;

        }


        static int printQuestions(int numOfQuestions, bool finishedTest, int correct)
        {
            Random rnd = new Random();

            char userAnswer = ' ';

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
                        correct = question1(correct, userAnswer);
                        break;

                    case 2:
                        correct = question2(correct, userAnswer);
                        break;

                    case 3:
                        correct = question3(correct, userAnswer);
                        break;

                    case 4:
                        correct = question4(correct, userAnswer);
                        break;

                    case 5:
                        correct = question5(correct, userAnswer);
                        break;

                    case 6:
                        correct = question6(correct, userAnswer);
                        break;

                    case 7:
                        correct = question7(correct, userAnswer);
                        break;

                    case 8:
                        correct = question8(correct, userAnswer);
                        break;

                    case 9:
                        correct = question9(correct, userAnswer);
                        break;

                    case 10:
                        correct = question10(correct, userAnswer);
                        break;

                    default:
                        break;
                }

            }

            Console.WriteLine("End of questions");

            return correct;

            finishedTest = true;
        }

        static void Main(string[] args)
        {

            int correct = 0;

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

                while (backTimerChoice != true)
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
                            Console.ReadKey();
                        }

                        else if (option == 6)
                        {
                            Console.WriteLine("back");
                        }

                        backTimerChoice = true;

                    }
                }

            }

            Console.Clear();

            Console.WriteLine("Do you want to have a normal sized test or a short test?");

            int numOfQuestions = 0;

            Console.WriteLine("");

            Console.WriteLine("  Normal");
            Console.WriteLine("  Short");

            Console.CursorTop = 2;
            Console.CursorLeft = 0;
            Console.Write(">");

            int testSizeChoice = 2;
            bool backQuestionSize = false;

            while (backQuestionSize != true)
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
                    }

                    else if (testSizeChoice == 3)
                    {
                        numOfQuestions = 5;
                    }

                    backQuestionSize = true;

                }
            }

            Console.WriteLine("Questions will now be started");

            Console.ReadKey();

            bool finishedTest = false;

            Console.Clear();
            
            //stops here for some reason

            if (countdown == true || stopwatch == true)
            {
                Stopwatch.Start();
            }

            correct = printQuestions(numOfQuestions, finishedTest, correct);

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

            int percentageCorrect1 = correct / numOfQuestions;
            int percentageCorrect2 = percentageCorrect1 * 100;

            Console.WriteLine("You got " + correct + " (" + percentageCorrect2 + "%) " + "answers correct!");

            Console.ReadKey();

        }
    }
}