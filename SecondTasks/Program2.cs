using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTasks
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Copy - Paste an Excercise in main method to test it!");
        }
        public void Exercise1()
        {
            var counter = 0;
            for (int i = 0; i < 100; i++)
            {
                if ((i % 3) == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }

        public void Exercise2()
        {
            
                int sum = 0;
                while (true)
                {
                    Console.WriteLine("Enter a number or 'ok' to exit");
                    var input = Console.ReadLine();
                    if (input.ToLower() == "ok")
                    {
                        break;
                    }
                    sum += Convert.ToInt32(input);
                }
                Console.WriteLine(sum);
        }

        public void Excerscise3()
        {
            Console.Write("Write a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int fac = 1;
            for (int i = 1; i <= number; i++)
            {
                fac = fac * i;
            }
            Console.WriteLine(number + "! = " + fac);
        }
        
        public void Excercise4()
        {
            var random = new Random();
            int number = random.Next(1, 10);
            Console.WriteLine(number);
            bool found = false;
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Write a number: ");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == number)
                {
                    found = true;
                    break;
                }
            }
            if (found == true)
            {
                Console.WriteLine("You won");
            }
            else
            {
                Console.WriteLine("You lost");
            }
        }

        public void Excercise5()
        {
            Console.Write("Write a series of numbers: ");
            string input = Console.ReadLine();
            var input2 = input.Split(',');
            int max = Convert.ToInt32(input2[0]);
            for (int i = 1; i < input2.Length; i++)
            {
                if (Convert.ToInt32(input2[i]) > max)
                {
                    max = Convert.ToInt32(input2[i]);
                }
            }
            Console.WriteLine(max);
        }
    }
}
