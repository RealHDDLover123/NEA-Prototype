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
