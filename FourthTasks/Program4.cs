﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimes
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            
        }

        public void Excercise1()
        {
            Console.Write("Enter a time value(24 hour format): ");
            var input = Console.ReadLine();
            try
            {
                var time = TimeSpan.Parse(input);
                if (time >= TimeSpan.FromHours(0) && time <= TimeSpan.FromHours(23).Add(TimeSpan.FromMinutes(59)))
                {
                    Console.WriteLine("Ok");
                }
                else
                {
                    Console.WriteLine("Invalid Time");
                }
            }
            catch
            {
                Console.WriteLine("Invalid");
            }
        }

        public void DateTimeMethods()
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            //Console.WriteLine("Hour: " + now.Hour);
            //Console.WriteLine("Minute: " + now.Minute); 

            var tommorow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
        }

        public void TimeSpanMethods()
        {
            //Creating
            var timeSpan = new TimeSpan(1, 2, 3);

            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            //Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            //Add
            Console.WriteLine("TimeSpan: " + timeSpan);
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Add Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //ToString
            Console.WriteLine("ToString" + timeSpan.ToString());

            //Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}
