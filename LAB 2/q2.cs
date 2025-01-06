using System;
using System.Collections.Generic;

namespace lab2
{
    internal class q2
    {
        class NumberCollection
        {
            public void DisplayNumbers(List<int> numbers)
            {
                Console.WriteLine("The numbers in the collection are:");
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
            }
        }

        static void Main(string[] args)
        {
            NumberCollection collection = new NumberCollection();

]
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

]
            collection.DisplayNumbers(numbers);

            Console.ReadKey();
        }
    }
}