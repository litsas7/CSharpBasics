using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTasks
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Copy Paste an Excercise in main method");
        }

        public void Excercise1()
        {
            var names = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter a name (or hit enter to stop): ");
                string input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                    break;
                names.Add(input);
            }
            if (names.Count == 0)
                Console.WriteLine("");
            else if (names.Count == 1)
                Console.WriteLine(names[0] + " likes your post.");
            else if (names.Count == 2)
                Console.WriteLine(names[0] + " and " + names[1] + " like your post.");
            else
                Console.WriteLine(names[0] + "," + names[1] + " and " + (names.Count - 2) + " others like your post");
        }

        public void Excercise2()
        {
            Console.Write("Write your name: ");
            var name = Console.ReadLine();
            var name2 = new char[name.Length];
            for (int i = name.Length; i > 0; i--)
            {
                name2[name.Length - i] = name[i - 1];
            }
            var name3 = new string(name2);
            Console.WriteLine(name3);
        }

        public void Excercise3()
        {
            int input;
            var list = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter a number.");
                input = Convert.ToInt32(Console.ReadLine());
                if (list.Contains(input))
                {
                    while (list.Contains(input))
                    {
                        Console.WriteLine("Retry. Enter a number.");
                        input = Convert.ToInt32(Console.ReadLine());
                    }

                }
                list.Add(input);

            }
            list.Sort();
            foreach (int num in list)
            {
                Console.Write(num + " ");
            }
        }

        public void Excercise4()
        {
            var numbers = new List<int>();
            while (true)
            {
                Console.Write("Enter a number: ");
                var input = Console.ReadLine();
                if (String.Equals(input.ToLower(), "quit"))
                {
                    break;
                }
                int number = Convert.ToInt32(input);
                numbers.Add(number);
            }
            var uniques = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (!uniques.Contains(numbers[i]))
                    uniques.Add(numbers[i]);
            }
            foreach (int i in uniques)
                Console.Write(i + " ");
        }

        public void Excercise5()
        {
            string[] elements;
            while (true)
            {
                Console.Write("Enter a list of comma-separated numbers: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;
                }

                Console.WriteLine("Invalid List");
            }

            var numbers = new List<int>();
            foreach (var number in elements)
                numbers.Add(Convert.ToInt32(number));

            var smallests = new List<int>();
            while (smallests.Count < 3)
            {
                // Assume the first number is the smallest
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallests.Add(min);

                numbers.Remove(min);
            }

            Console.WriteLine("The 3 smallest numbers are: ");
            foreach (var number in smallests)
                Console.WriteLine(number);
        }
    

        public void ArrayMethods()
        {
            int[] numbers = new int[] { 3, 7, 9, 2, 14, 6 };
            // Length
            Console.WriteLine("Length: " + numbers.Length);

            //IndexOf
            var index = Array.IndexOf(numbers, 3);
            Console.WriteLine("Index of 3: " + index);

            //Clear
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect of Clear: ");
            foreach (var n in numbers)
                Console.WriteLine(n);

            //Copy
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of Copy: ");
            foreach (var n in another)
                Console.WriteLine(n);

            //Sort
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort: ");
            foreach (var n in numbers)
                Console.WriteLine(n);

            //Reverse
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse: ");
            foreach (var n in numbers)
                Console.WriteLine(n);
        }

        public void ListMethods()
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach (var number in numbers)
                Console.WriteLine(number);

            Console.WriteLine();
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1)); // 0
            Console.WriteLine("Last index of 1: " + numbers.LastIndexOf(1)); // 4

            Console.WriteLine("Count: " + numbers.Count); // 8


            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }
            foreach (var number in numbers)
                Console.WriteLine(number);

            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count); // 0
        }
    }
}
