using System;

namespace LAB2
{
    internal class q3
    {
        interface IOperations
        {
            void Add(int x, int y);
            void Subtract(int x, int y);
            void Multiply(int x, int y);
            void Divide(int x, int y);
        }

        class Calculator : IOperations
        {
            public void Add(int x, int y)
            {
                Console.WriteLine("Sum is: " + (x + y));
            }

            public void Subtract(int x, int y)
            {
                Console.WriteLine("Difference is: " + (x - y));
            }

            public void Multiply(int x, int y)
            {
                Console.WriteLine("Product is: " + (x * y));
            }

            public void Divide(int x, int y)
            {
                if (y != 0)
                {
                    Console.WriteLine("Quotient is: " + (x / (double)y));
                }
                else
                {
                    Console.WriteLine("Division by zero is not allowed.");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int y = int.Parse(Console.ReadLine());

            Calculator calculator = new Calculator();
            calculator.Add(x, y);
            calculator.Subtract(x, y);
            calculator.Multiply(x, y);
            calculator.Divide(x, y);

            Console.ReadKey();
        }
    }
}
