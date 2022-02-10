using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("== Stop Watch ==\n\n");
            Console.WriteLine("- Menu -\n");
            Console.WriteLine("0 - exit");
            Console.WriteLine("S - seconds:");
            Console.WriteLine("M for minutes\n");

            Console.Write("Choose your option: ");
            char typeTime = char.Parse(Console.ReadLine().ToLower());

            if (typeTime == '0')
                System.Environment.Exit(0);

            Console.Write("\nHow much time do you want: ");
            int time = int.Parse(Console.ReadLine());
            int multiplier = 1;

            if (typeTime == 'm')
                multiplier = 60;

            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...\n");
            Thread.Sleep(1000);

            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine($"Time: {currentTime}");
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("\n\nStopWatch finished\n\n");
            Thread.Sleep(2000);
            Menu();
        }
    }
}
