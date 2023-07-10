using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace Timer_Tests
{
    internal class Program
    {

        static void countdown(int mins/*, int secs*/)
        {

            /*            for (int i = mins; i > 0; i--)
                        {
                            Console.WriteLine(i + " minutes, ");
                            System.Threading.Thread.Sleep(60000);
                        }

                        for (int i = secs; i > 0; i--)
                        {
                            Console.Write(i + " seconds left");
                            System.Threading.Thread.Sleep(1000);
                        }*/

            /*var elapsedTime = new DateTime(1000, 1, 1, 0, mins, 0);

            for (int i = 0; i <= mins * 60; i++)
            {
                Console.Write(elapsedTime.ToString("\rmm:ss"));
                elapsedTime = elapsedTime.AddSeconds(-1);
                System.Threading.Thread.Sleep(1000);
            }*/

            /*CountdownEvent Countdown = new CountdownEvent(mins * 60000);

            System.Threading.Thread.Sleep(5000);

            Console.WriteLine(Countdown.Signal());*/

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            System.Threading.Thread.Sleep(5000); //only used for tests

            stopwatch.Stop();

            TimeSpan elapsedTime = stopwatch.Elapsed;

            string time = String.Format("{0:00}:{1:00}:{2:00}", elapsedTime.Hours, elapsedTime.Minutes, elapsedTime.Seconds);

            TimeSpan countdownTime = TimeSpan.FromMinutes(10) - elapsedTime;

            Console.WriteLine("Time is " + countdownTime);

        }

        static void stopWatch()
        {

            /*bool minutes = false;

            for (int i = 0; i >= 0; i++)
            {

                if (i >= 60)
                {
                    minutes = true;
                }

                if (minutes == true)
                {
                    int minuteCount = i - 60;
                    Console.WriteLine(minuteCount + " minutes and " + i + " seconds left");
                    System.Threading.Thread.Sleep(1000);
                }

                else
                {
                    Console.WriteLine(i + " seconds");
                    System.Threading.Thread.Sleep(1000);
                }

            }*/

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            System.Threading.Thread.Sleep(5000); //only used for tests

            stopwatch.Stop();

            TimeSpan elapsedTime = stopwatch.Elapsed;

            string time = String.Format("{0:00}:{1:00}:{2:00}", elapsedTime.Hours, elapsedTime.Minutes, elapsedTime.Seconds);

            Console.WriteLine("Time is " + time);

        }

        static void Main(string[] args)
        {

            Console.WriteLine("Type either countdown or stopwatch");
            string choice = Console.ReadLine();



            if (choice == "countdown")
            {
                Console.WriteLine("Enter minutes");
                int mins = int.Parse(Console.ReadLine());
                /*Console.WriteLine("Enter seconds");
                int secs = int.Parse(Console.ReadLine());*/

                countdown(mins/*, secs*/);
            }

            else
            {
                stopWatch();
            }

            Console.ReadKey();

        }
    }
}
