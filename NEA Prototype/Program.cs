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

        static char skip(int skips)
        {
            skips--;

            return (char)skips;
        }

        static char questionAnswerSelector(char userAnswer, int skips)
        {

            Console.WriteLine("");

            Console.WriteLine("  a");
            Console.WriteLine("  b");
            Console.WriteLine("  c");
            Console.WriteLine("  d");
            Console.WriteLine("  e");

            if (skips != 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("  SKIP");
                Console.ResetColor();
            }

            Console.CursorTop = 3;
            Console.CursorLeft = 0;
            Console.Write(">");

            int option = 3;
            bool back = false;

            while (back != true)
            {
                ConsoleKeyInfo choice = Console.ReadKey(true);

                if (choice.Key == ConsoleKey.DownArrow && option < 8)
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

                    if (userAnswer == 8)
                    {
                        //skip(skips);
                        skips--;
                    }

                    userAnswer = (char)(option + 62);
                    back = true;

                }
            }

            return userAnswer;
            return (char)skips;
        }

        //the way these questions are structured is just as a proof of concept, this will be done differently when its in the final program

        static int question1(int correct, char userAnswer, int skips)
        {
            Console.WriteLine("question 1");
            Console.WriteLine("Answer is b");
            userAnswer = questionAnswerSelector(userAnswer, skips);

            if (userAnswer == 'B')
            {
                correct++;
            }

            return correct;

        }

        static int question2(int correct, char userAnswer, int skips)
        {
            Console.WriteLine("question 2");
            Console.WriteLine("Answer is a");
            userAnswer = questionAnswerSelector(userAnswer, skips);

            if (userAnswer == 'A')
            {
                correct++;
            }

            return correct;

        }

        static int question3(int correct, char userAnswer, int skips)
        {
            Console.WriteLine("question 3");
            Console.WriteLine("Answer is c");
            userAnswer = questionAnswerSelector(userAnswer, skips);

            if (userAnswer == 'C')
            {
                correct++;
            }

            return correct;

        }

        static int question4(int correct, char userAnswer, int skips)
        {
            Console.WriteLine("question 4");
            Console.WriteLine("Answer is e");
            userAnswer = questionAnswerSelector(userAnswer, skips);

            if (userAnswer == 'E')
            {
                correct++;
            }

            return correct;

        }

        static int question5(int correct, char userAnswer, int skips)
        {
            Console.WriteLine("question 5");
            Console.WriteLine("Answer is d");
            userAnswer = questionAnswerSelector(userAnswer, skips);

            if (userAnswer == 'D')
            {
                correct++;
            }

            return correct;

        }

        static int question6(int correct, char userAnswer, int skips)
        {
            Console.WriteLine("question 6");
            Console.WriteLine("Answer is d");
            userAnswer = questionAnswerSelector(userAnswer, skips);

            if (userAnswer == 'D')
            {
                correct++;
            }

            return correct;

        }

        static int question7(int correct, char userAnswer, int skips)
        {
            Console.WriteLine("question 7");
            Console.WriteLine("Answer is a");
            userAnswer = questionAnswerSelector(userAnswer, skips);

            if (userAnswer == 'A')
            {
                correct++;
            }

            return correct;

        }

        static int question8(int correct, char userAnswer, int skips)
        {
            Console.WriteLine("question 8");
            Console.WriteLine("Answer is b");
            userAnswer = questionAnswerSelector(userAnswer, skips);

            if (userAnswer == 'B')
            {
                correct++;
            }

            return correct;

        }

        static int question9(int correct, char userAnswer, int skips)
        {
            Console.WriteLine("question 9");
            Console.WriteLine("Answer is c");
            userAnswer = questionAnswerSelector(userAnswer, skips);

            if (userAnswer == 'C')
            {
                correct++;
            }

            return correct;

        }

        static int question10(int correct, char userAnswer, int skips)
        {
            Console.WriteLine("question 10");
            Console.WriteLine("Answer is b");
            userAnswer = questionAnswerSelector(userAnswer, skips);

            if (userAnswer == 'B')
            {
                correct++;
            }

            return correct;

        }


        static int printQuestions(int numOfQuestions, bool finishedTest, int correct, int skips)
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
                        correct = question1(correct, userAnswer, skips);
                        break;

                    case 2:
                        correct = question2(correct, userAnswer, skips);
                        break;

                    case 3:
                        correct = question3(correct, userAnswer, skips);
                        break;

                    case 4:
                        correct = question4(correct, userAnswer, skips);
                        break;

                    case 5:
                        correct = question5(correct, userAnswer, skips);
                        break;

                    case 6:
                        correct = question6(correct, userAnswer, skips);
                        break;

                    case 7:
                        correct = question7(correct, userAnswer, skips);
                        break;

                    case 8:
                        correct = question8(correct, userAnswer, skips);
                        break;

                    case 9:
                        correct = question9(correct, userAnswer, skips);
                        break;

                    case 10:
                        correct = question10(correct, userAnswer, skips);
                        break;

                    default:
                        break;
                }

                /*Dictionary<int, Func<int, char>> questionProperties = new Dictionary<int, Func<int, char>>
                {
                    { 1, question1 },
                    { 2, question2 },
                    { 3, question3(correct, userAnswer) },
                    { 4, question4(correct, userAnswer) },
                    { 5, question5(correct, userAnswer) },
                    { 6, question6(correct, userAnswer) },
                    { 7, question7(correct, userAnswer) },
                    { 8, question8(correct, userAnswer) },
                    { 9, question9(correct, userAnswer) },
                    { 10, question10(correct, userAnswer) }
                };

                if (questionProperties.TryGetValue(chosenQuestion, out Func<int, char> questionFunction))
                {
                    // Call the corresponding question function
                    correct = questionFunction(correct, userAnswer);
                }*/

            }

            Console.WriteLine("End of questions");

            return correct;

            finishedTest = true;
        }

        static void Main(string[] args)
        {

            int skips = 0;

            int correct = 0;

            Stopwatch Stopwatch = new Stopwatch();

            bool countdown = false;
            bool stopwatch = false;
            bool timerInfo = false;

            Console.WriteLine("Do you wish to have a timer?");
            bool timerChoice = false;

            Console.WriteLine("");

            Console.WriteLine("  Yes");
            Console.WriteLine("  No");

            Console.CursorTop = 2;
            Console.CursorLeft = 0;
            Console.Write(">");

            int timerOption = 2;
            bool backTimerChoice = false;

            while (backTimerChoice != true)
            {
                ConsoleKeyInfo choice = Console.ReadKey(true);

                if (choice.Key == ConsoleKey.DownArrow && timerOption < 3)
                {
                    Console.CursorTop = timerOption;
                    Console.CursorLeft = 0;
                    Console.Write(" ");
                    timerOption++;
                    Console.CursorTop = timerOption;
                    Console.CursorLeft = 0;
                    Console.Write(">");
                }

                else if (choice.Key == ConsoleKey.UpArrow && timerOption > 2)
                {
                    Console.CursorTop = timerOption;
                    Console.CursorLeft = 0;
                    Console.Write(" ");
                    timerOption--;
                    Console.CursorTop = timerOption;
                    Console.CursorLeft = 0;
                    Console.Write(">");
                }

                else if (choice.Key == ConsoleKey.Enter)
                {

                    Console.Clear();

                    if (timerOption == 2)
                    {
                        timerChoice = true;
                    }

                    backTimerChoice = true;

                }
            }

            if (timerChoice == true)
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
                Console.WriteLine("  Cancel");

                Console.CursorTop = 2;
                Console.CursorLeft = 0;
                Console.Write(">");

                int specificTimerOption = 2;
                bool backSpecificTimerChoice = false;

                while (backSpecificTimerChoice != true && timerInfo != true)
                {
                    ConsoleKeyInfo choice = Console.ReadKey(true);

                    if (choice.Key == ConsoleKey.DownArrow && specificTimerOption < 5)
                    {
                        Console.CursorTop = specificTimerOption;
                        Console.CursorLeft = 0;
                        Console.Write(" ");
                        specificTimerOption++;
                        Console.CursorTop = specificTimerOption;
                        Console.CursorLeft = 0;
                        Console.Write(">");
                    }

                    else if (choice.Key == ConsoleKey.UpArrow && specificTimerOption > 2)
                    {
                        Console.CursorTop = specificTimerOption;
                        Console.CursorLeft = 0;
                        Console.Write(" ");
                        specificTimerOption--;
                        Console.CursorTop = specificTimerOption;
                        Console.CursorLeft = 0;
                        Console.Write(">");
                    }

                    else if (choice.Key == ConsoleKey.Enter)
                    {

                        Console.Clear();

                        if (specificTimerOption == 2)
                        {
                            stopwatch = true;
                        }

                        else if (specificTimerOption == 3)
                        {
                            countdown = true;
                        }

                        else if (specificTimerOption == 4)
                        {

                            //timerInfo = true;

                            //MAKE IT SO THIS THING GOES BACK TO THE OPTIONS AGAIN (e.g. line 314)

                            Console.WriteLine("Stopwatch");
                            Console.WriteLine();
                            Console.WriteLine("A stopwatch is used to measure the elapsed time of an event, and if you select this option you will see how long you took to finish the test (e.g. 01:08, being 1 minute 8 seconds.).");
                            
                            Console.WriteLine();
                            Console.WriteLine();

                            Console.WriteLine("Countdown");
                            Console.WriteLine();
                            Console.WriteLine("A countdown is a timer that counts backward from a specified duration to zero, and if you select this option you will see how long you had left to finish the test (e.g. 00:02:45, being 2 minutes 45 seconds remaining.). ");
                            Console.ReadKey();
                        }

                        backSpecificTimerChoice = true;

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
                        skips = 3;
                    }

                    else if (testSizeChoice == 3)
                    {
                        numOfQuestions = 5;
                        skips = 1;
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

            correct = printQuestions(numOfQuestions, finishedTest, correct, skips);

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

                Console.WriteLine("The time left was " + countdownTime);
            }


            double percentageCorrect = (Convert.ToDouble(correct) / Convert.ToDouble(numOfQuestions)) * 100;

            Console.WriteLine("You got " + correct + " (" + percentageCorrect + "%) " + "answers correct, and had " + skips + " skips remaining!");

            Console.ReadKey();

        }
    }
}