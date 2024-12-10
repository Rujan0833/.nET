using System;

namespace lab1
{
    internal class Program
    {
        class Studentq2
        {
            public int StudentId { get; set; }
            public string StudentName { get; set; }
            public void Studentq(int id, string name)
            {
                this.StudentId = id;
                this.StudentName = name;

                Console.WriteLine($"Student ID: {StudentId}, Student Name: {StudentName}");
            }
        }

        static void Main(string[] args) 
        {
            Studentq2 stq = new Studentq2();
            stq.Studentq(101, "Magnus Carlson");


            Console.ReadKey();
        }
    }
}
