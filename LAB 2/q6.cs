using System;

namespace lab2
{
    class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message) { }
    }

    class q6
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter balance: ");
                double balance = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter withdrawal amount: ");
                double withdraw = Convert.ToDouble(Console.ReadLine());

                if (withdraw > balance)
                    throw new InsufficientBalanceException("Error: Withdrawal amount exceeds balance!");

                Console.WriteLine($"Remaining balance: {balance - withdraw:F2}");
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter numeric values.");
            }
        }
    }

}