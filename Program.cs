﻿namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter yuor name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte age = checked((byte) int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);
            Console.Write("What is your favorite day of week? ");
            DayOfWeek day = (DayOfWeek) int.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite day is {0}", day);
        }
	}
}