using System;

namespace lab1
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }

    interface IDriver
    {
        void Drive();
    }

    interface IWorker
    {
        void Work();
    }

    class DriverWorker : IDriver, IWorker
    {
        public void Drive()
        {
            Console.WriteLine("Driver is driving.");
        }

        public void Work()
        {
            Console.WriteLine("Worker is working.");
        }
    }

    class Vehicle
    {
        public void Start()
        {
            Console.WriteLine("Vehicle is starting.");
        }
    }

    class Car : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving.");
        }
    }

    class ElectricCar : Car
    {
        public void Charge()
        {
            Console.WriteLine("Electric car is charging.");
        }
    }

    class Shape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a shape.");
        }
    }

    class Circle : Shape
    {
        public void DrawCircle()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    class Square : Shape
    {
        public void DrawSquare()
        {
            Console.WriteLine("Drawing a square.");
        }
    }

    class INheritance
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            DriverWorker driverWorker = new DriverWorker();
            driverWorker.Drive();
            driverWorker.Work();

            ElectricCar electricCar = new ElectricCar();
            electricCar.Start();
            electricCar.Drive();
            electricCar.Charge();

            Circle circle = new Circle();
            circle.Draw();
            circle.DrawCircle();

            Square square = new Square();
            square.Draw();
            square.DrawSquare();

            Console.ReadKey();
        }
    }
}
