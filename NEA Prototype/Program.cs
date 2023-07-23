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

        static string questionAnswerSelector(int questionNumber, ref int skips, Dictionary<int, string[]> questions)
        {
            string userAnswer = "";

            Console.WriteLine("");

            Console.WriteLine($"  a) {questions[questionNumber][2]}");
            Console.WriteLine($"  b) {questions[questionNumber][3]}");
            Console.WriteLine($"  c) {questions[questionNumber][4]}");
            Console.WriteLine($"  d) {questions[questionNumber][5]}");
            Console.WriteLine($"  e) {questions[questionNumber][6]}");

            if (skips > 0)
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

                    if (option == 8)
                    {
                        skips--;
                    }

                    userAnswer += (char)(option + 62);
                    userAnswer = userAnswer.ToLower();
                    back = true;

                }
            }

            return userAnswer;
        }

        static int Question(Dictionary<int, string[]> questions, ref int skips, int correct, int questionNumber)
        {
            System.Console.WriteLine(questions[questionNumber][0]);
            System.Console.WriteLine(questions[questionNumber][1]);
            string userAnswer = questionAnswerSelector(questionNumber, ref skips, questions);

            if (userAnswer == questions[questionNumber][1])
            {
                correct++;
            }

            return correct;

        }

        static int printQuestions(int numOfQuestions, bool finishedTest, int correct, ref int skips)
        {
            Random rnd = new Random();

            List<int> listOfUniqueNumbers = new List<int>();

            while (listOfUniqueNumbers.Count < numOfQuestions)
            {
                for (int i = 0; i < numOfQuestions + 1 - listOfUniqueNumbers.Count; i++)
                {
                    int chosenQuestionNumber = rnd.Next(1, 11 /* this number should be the maximum possible amount of questions + 1 */);

                    if (!listOfUniqueNumbers.Contains(chosenQuestionNumber))
                    {
                        listOfUniqueNumbers.Add(chosenQuestionNumber);
                    }
                }
            }

            Dictionary<int, string[]> questions = new Dictionary<int, string[]>()
            {
                                              // v short answer (single letter a-e)
                {1, new string[] {"Question 1", "a", "A answer", "B answer", "C answer", "D answer", "E answer"}},
                {2, new string[] {"Question 2", "b", "A answer", "B answer", "C answer", "D answer", "E answer"}},
                {3, new string[] {"Question 3", "c", "A answer", "B answer", "C answer", "D answer", "E answer"}},
                {4, new string[] {"Question 4", "d", "A answer", "B answer", "C answer", "D answer", "E answer"}},
                {5, new string[] {"Question 5", "e", "A answer", "B answer", "C answer", "D answer", "E answer"}},
                {6, new string[] {"Question 6", "b", "A answer", "B answer", "C answer", "D answer", "E answer"}},
                {7, new string[] {"Question 7", "c", "A answer", "B answer", "C answer", "D answer", "E answer"}},
                {8, new string[] {"Question 8", "a", "A answer", "B answer", "C answer", "D answer", "E answer"}},
                {9, new string[] {"Question 9", "e", "A answer", "B answer", "C answer", "D answer", "E answer"}},
                {10, new string[] {"Question 10", "d", "A answer", "B answer", "C answer", "D answer", "E answer"}}

            };

            for (int i = 0; i < listOfUniqueNumbers.Count; i++)
            {
                int chosenQuestion = listOfUniqueNumbers[i];

                correct = Question(questions, ref skips, correct, listOfUniqueNumbers[i]);

            }

            Console.WriteLine("End of questions");

            return correct;

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

                int specificTimerOption = 2;

                do
                {

                    Console.Clear();

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

                    bool backSpecificTimerChoice = false;
                    specificTimerOption = 2;

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
                    
                } while (specificTimerOption == 4);


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

            if (countdown == true || stopwatch == true)
            {
                Stopwatch.Start();
            }

            correct = printQuestions(numOfQuestions, finishedTest, correct, ref skips);

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