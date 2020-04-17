using GenericFunction.Functions;
using System;
using System.Collections.Generic;

namespace GenericFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            GetInformation();
            Console.ReadKey();
        }

        static void GetInformation()
        {
            Console.Clear();
            Console.WriteLine("Choose an execice:");
            Console.WriteLine("1 - Show Parameters");
            Console.WriteLine("2 - Show Array of Parameters");
            Console.WriteLine("3 - Show List of Parameters");
            Console.WriteLine(" ");
            Console.Write("Your Choice : ");
            CheckAnswer(Console.ReadLine());
        }

        static void CheckAnswer(string answer)
        {
            switch (answer)
            {
                case "1":
                    ShowParameters();
                    break;

                case "2":
                    ShowArrayParameters();
                    break;

                case "3":
                    ShowListParameters();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("This excercice doesn't existe!");
                    break;
            }

            Console.WriteLine("");
            Console.WriteLine("******************************************");
            Console.WriteLine("Do you want to continue?");
            Console.WriteLine("Y - YES");
            Console.WriteLine("N  - NO");
            Console.WriteLine("");
            Console.Write("Type your answer:");

            if (Console.ReadLine().ToUpper() == "Y")
            {
                GetInformation();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Thanks for using our system");
            }
        }

        static void ShowParameters()
        {
            ClassFunctions.ShowParameter(2020);
            ClassFunctions.ShowParameter(569f);
            ClassFunctions.ShowParameter(784d);
            ClassFunctions.ShowParameter("Car");
            ClassFunctions.ShowParameter(true);
            ClassFunctions.ShowParameter(DateTime.Now);
        }

        static void ShowArrayParameters()
        {
            ClassFunctions.ShowItemFromArray(1, 3, 49, 899, 356);
            ClassFunctions.ShowItemFromArray("car", "house", "route");
            ClassFunctions.ShowItemFromArray(true, true, false, false);
        }

        static void ShowListParameters()
        {
            List<int> numbers = new List<int>()
            {
                1,
                30,
                4
            };

            List<string> words = new List<string>()
            {
                "wather",
                "wine",
                "soda"
            };

            List<bool> tests = new List<bool>()
            {
                true,
                false,
                true
            };

            ClassFunctions.ShowItemFromList(numbers);
            ClassFunctions.ShowItemFromList(words);
            ClassFunctions.ShowItemFromList(tests);
        }
    }
}
