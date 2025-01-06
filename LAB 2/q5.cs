using System;
using System.Collections.Generic;

namespace lab2
{
    class Dictionary
    {
        static void Main()
        {
            Dictionary<int, string> customers = new Dictionary<int, string>();

            customers[101] = "Rujan Rajlawat";
            customers[102] = "Khrisha Tuladhar";
            customers[103] = "Magnus Carlson";
            customers[104] = "Savin CartT";

            Console.WriteLine("CustomerId and CustomerName:");
            foreach (KeyValuePair<int, string> customer in customers)
            {
                Console.WriteLine($"CustomerId: {customer.Key}, CustomerName: {customer.Value}");
            }
        }
    }

}