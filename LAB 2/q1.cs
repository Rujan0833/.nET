using System;

namespace lab2
{
    internal class q1
    {
        class StringImmutabilityDemo
        {
            public void DemonstrateImmutability()
            {

                string originalString = "Hello";
                Console.WriteLine("Original String: " + originalString);

 
                string modifiedString = originalString.Replace('e', 'a');


                Console.WriteLine("After Replace Attempt:");
                Console.WriteLine("Original String: " + originalString);
                Console.WriteLine("Modified String: " + modifiedString);


                Console.WriteLine("Are the references equal? " + ReferenceEquals(originalString, modifiedString));
            }
        }

        static void Main(string[] args)
        {
            StringImmutabilityDemo demo = new StringImmutabilityDemo();
            demo.DemonstrateImmutability();

            Console.ReadKey();
        }
    }
}