using System;

namespace ConsoleVariablesEasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Fizzbuzz!!");
            Console.WriteLine("How many numbers do you want to Fizzbuzz through?");
            long numbers = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Here are the numbers FizzBuzzed: ");

            for (int i = 1; i <= numbers; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Fizzbuzz!");
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz!");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
