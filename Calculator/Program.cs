using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            Console.Clear();

            Console.WriteLine("What do you want to calculate?");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Division");
            Console.WriteLine("4 - Multiplication");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("==============================\n");

            Console.Write("Choose your option: ");
            short resMenu = short.Parse(Console.ReadLine());

            switch (resMenu)
            {
                case 1: Sum(); break;
                case 2: Subtraction(); break;
                case 3: Division(); break;
                case 4: Multiplication(); break;
                case 0: ExitCalculator(); break;
                default: Menu(); break;
            }

            Console.ReadKey();
        }

        private static void ExitCalculator()
        {
            Console.Clear();
            Console.WriteLine("===============================\n\n");
            Console.WriteLine("Thank you for using our system!\n\n");
            Console.WriteLine("===============================\n\n");
            System.Environment.Exit(0);
        }

        private static void Sum()
        {
            Console.Clear();
            Console.WriteLine("1 - Sum");
            Console.WriteLine("===============================\n\n");
            Console.WriteLine("First value: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Second value:");
            double v2 = double.Parse(Console.ReadLine());

            double result = v1 + v2;
            Console.WriteLine();

            Console.WriteLine($"The result of sum is: {result}");
            Console.ReadKey();
            Menu();
        }

        private static void Subtraction()
        {
            Console.Clear();
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("===============================\n\n");
            Console.WriteLine("First value:");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Second value:");
            double v2 = double.Parse(Console.ReadLine());

            double result = v1 - v2;
            Console.WriteLine();

            Console.WriteLine($"The result of subtraction is: {result}");
            Console.ReadKey();
            Menu();
        }

        private static void Division()
        {
            Console.Clear();
            Console.WriteLine("3 - Division");
            Console.WriteLine("===============================\n\n");
            Console.WriteLine("First value:");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Second value:");
            double v2 = double.Parse(Console.ReadLine());

            double result = v1 / v2;
            Console.WriteLine();

            Console.WriteLine($"The result of division is: {result}");
            Console.ReadKey();
            Menu();
        }

        private static void Multiplication()
        {
            Console.Clear();
            Console.WriteLine("4 - Multiplication");
            Console.WriteLine("===============================\n\n");
            Console.WriteLine("First value:");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Second value:");
            double v2 = double.Parse(Console.ReadLine());

            double result = v1 * v2;
            Console.WriteLine();

            Console.WriteLine($"The result of multiplication is: {result}");
            Console.ReadKey();
            Menu();
        }
    }
}
