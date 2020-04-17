using System;
using System.Collections.Generic;

namespace GenericFunction.Functions
{
    public static class ClassFunctions
    {
        public static void ShowParameter<T>(T item)
        {
            Console.WriteLine("******************************************");
            Console.WriteLine($"The parameter is {item}");
            Console.WriteLine($"The type of parameter is {item.GetType()}");
            Console.WriteLine("******************************************");
            Console.WriteLine("");
        }

        public static void ShowItemFromArray<T>(params T[] items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
        }

        public static void ShowItemFromList<T>(List<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
        }
    }
}
