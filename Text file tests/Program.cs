using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_file_tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("questions_test.txt"))
            {
                string one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve, thirteen, fourteen, fifteen, sixteen, seventeen, eighteen, nineteen, twenty, twentyone, twentytwo, twentythree;
                string[] myArray = new string[1] {"PHYSICS"};

                while (sr.EndOfStream == false)
                {
                    one = sr.ReadLine();
                    two = sr.ReadLine();
                    three = sr.ReadLine();
                    four = sr.ReadLine();
                    five = sr.ReadLine();
                    six = sr.ReadLine();
                    seven = sr.ReadLine();
                    eight = sr.ReadLine();
                    nine = sr.ReadLine();
                    ten = sr.ReadLine();
                    eleven = sr.ReadLine();
                    twelve = sr.ReadLine();
                    thirteen = sr.ReadLine();
                    fourteen = sr.ReadLine();
                    fifteen = sr.ReadLine();
                    sixteen = sr.ReadLine();
                    seventeen = sr.ReadLine();
                    eighteen = sr.ReadLine();
                    nineteen = sr.ReadLine();
                    twenty = sr.ReadLine();
                    twentyone = sr.ReadLine();
                    twentytwo = sr.ReadLine();
                    twentythree = sr.ReadLine();

                    //b = sr.ReadLine();

                    /*for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i].ToString() == myArray[i])
                        {
                            Console.Write("subject");
                        }
                    }*/

                    Console.WriteLine(one);
                    /*Console.WriteLine(two);
                    Console.WriteLine(three);
                    Console.WriteLine(four);
                    Console.WriteLine(five);
                    Console.WriteLine(six);
                    Console.WriteLine(seven);
                    Console.WriteLine(eight);
                    Console.WriteLine(nine);
                    Console.WriteLine(ten);
                    Console.WriteLine(eleven);
                    Console.WriteLine(twelve);
                    Console.WriteLine(thirteen);
                    Console.WriteLine(fourteen);
                    Console.WriteLine(fifteen);
                    Console.WriteLine(sixteen);
                    Console.WriteLine(seventeen);
                    Console.WriteLine(eighteen);
                    Console.WriteLine(nineteen);
                    Console.WriteLine(twenty);
                    Console.WriteLine(twentyone);
                    Console.WriteLine(twentytwo);
                    Console.WriteLine(twentythree);*/

                    //Console.WriteLine(b);
                }
            }

            Console.ReadKey();

        }
    }
}
