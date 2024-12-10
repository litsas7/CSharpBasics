using System;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;

namespace FirstTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Copy - Paste an Excercise in main method to test it!");
        }

        public void Excercise1 ()
        {
            Console.WriteLine("Please enter a number");
            var input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void Excercise2()
        {
            Console.WriteLine("Input first number");
            var input = Console.ReadLine();
            int number1 = Convert.ToInt32(input);
            Console.WriteLine("Input second number");
            input = Console.ReadLine();
            int number2 = Convert.ToInt32(input);
            int max = Math.Max(number1, number2);
            Console.WriteLine($"The maximum value is: {max}");
        }
        public void Excercise3()
        {
            Console.WriteLine("Input width");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input height");
            var height = Convert.ToInt32(Console.ReadLine());
            if (width > height)
            {
                Console.WriteLine("Landscape");
            }
            else
            {
                Console.WriteLine("Portrait");
            }
        }
        public void Excercise4()
        {
            Console.WriteLine("Enter the speed limit");
            var limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the spped of the car");
            var speed = Convert.ToInt32(Console.ReadLine());
            int demPoints = 0;
            if (speed <= limit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                demPoints = (speed - limit) / 5;
                if (demPoints > 12)
                {
                    Console.WriteLine("Suspended");
                }
                else
                {
                    Console.WriteLine("Demerit points: " + demPoints);
                }
            }
        }
    }
}