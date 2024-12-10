using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texts
{
    internal class Program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Copy Paste an Excercise in main method");
        }

        public void Excercise1()
        {
            Console.Write("Input some numbers seperated by (-): ");
            var input = Console.ReadLine();
            var numbers = input.Split('-');
            bool isConsecutive = true;

            Console.WriteLine(Consecutive(numbers) ? "Consecutive" : "Not Consecutive");
        }

        public static bool Consecutive(string[] numbers)
        {
            bool isConsecutive = true;
            for (int i = 1; i < numbers.Length; i++)
            {
                int prev = Convert.ToInt32(numbers[i - 1]);
                int current = Convert.ToInt32(numbers[i]);

                if (Math.Abs(current - prev) != 1)
                {
                    isConsecutive = false;
                    break;
                }
            }
            return isConsecutive;
        }

        public void Excercise2()
        {
            Console.Write("Input some numbers seperated by (-): ");
            var input = Console.ReadLine();
            if (!String.IsNullOrWhiteSpace(input))
            {
                var numbers = input.Split('-');
                bool dublicate = false;
                for (int i = 0; i < numbers.Length; i++)
                {
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        if (numbers[i] == numbers[j] && i != j)
                        {
                            dublicate = true;
                        }
                    }
                }
                if (dublicate)
                    Console.WriteLine("Dublicate");
            }
        }

        public void Excercise3()
        {
            Console.Write("Enter few words seperated by space: ");
            var input = Console.ReadLine().ToUpper();
            var words = input.Split(' ');
            var output = new StringBuilder();
            foreach (string word in words)
            {
                output.Append(word[0]);
                output.Append(word.Substring(1).ToLower());
            }
            Console.WriteLine(output);
        }

        public void Excercise4()
        {
            Console.Write("Write an English word: ");
            var input = Console.ReadLine().ToLower();

            var vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });
            var vowelsCount = 0;
            foreach (var character in input)
            {
                if (vowels.Contains(character))
                    vowelsCount++;
            }

            Console.WriteLine(vowelsCount);
        }


        public void StringMethods()
        {
            var fullName = "Mosh H ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim()); //Whitespace is gone
            Console.WriteLine("ToUpper: '{0}'", fullName.ToUpper()); //MOSH H 

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index); //Mosh
            var lastName = fullName.Substring(index + 1); //H 
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]); //Mosh
            Console.WriteLine("LastName: " + names[1]); //H 


            Console.WriteLine(fullName.Replace("Mosh", "Moshfegh")); //Returns new Strings, so the original is not effected

            if (String.IsNullOrWhiteSpace(""))
            {
                Console.WriteLine("Invalid");
            }

            //convertions
            string str = "25";
            var age = Convert.ToInt32(str);
            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));
        }

        public void StringBuilderMethods()
        {
            var builder = new StringBuilder("Hello World");

            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Insert(0, new string('-', 10));

            Console.WriteLine(builder);
        }
    }
}
