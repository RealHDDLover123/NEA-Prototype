using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_troubleshooting
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();

            int numOfQuestions = 10;

            //EVERYTHING ABOVE THIS IS JUST TO MAKE IT WORK, DONT COPY PASTE

            List<int> listOfUniqueNumbers = new List<int>();

            while (listOfUniqueNumbers.Count != numOfQuestions)
            {
                for (int i = 0; i < numOfQuestions + 1; i++)
                {
                    int chosenQuestion = rnd.Next(1, 11);

                    if (!listOfUniqueNumbers.Contains(chosenQuestion))
                    {
                        listOfUniqueNumbers.Add(chosenQuestion);
                    }
                }
            }

            

            //BELOW HERE IS JUST TESTS, DONT COPY PASTE

            for (int i = 0; i < listOfUniqueNumbers.Count; i++)
            {
                Console.WriteLine(listOfUniqueNumbers[i]);
            }

            Console.ReadKey();
        }
    }
}

//switch case

/*switch (chosenQuestion)
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
}*/


