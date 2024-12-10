using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    
    internal class Program
    {
        class sum
    {
        public int x;
        public int y;
        public sum(int x, int y)
        {
            Console.WriteLine($"sum is {x + y}");
        }
    }
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            sum add = new sum(x, y);
            Console.ReadKey();  
        }
    }
}
