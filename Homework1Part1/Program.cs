using System;

namespace Homework1Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Homework1Task1
            Console.Write("Write the square's side value : ");
            string s = Console.ReadLine();
            string s1 = string.Empty; //string of numbers to convert into Int32
            foreach (char value in s)
            {
                if (char.IsNumber(value))
                {
                    s1 = string.Concat(s1, value);
                }
            }
            int a = Convert.ToInt32(s1); //square's side value
            int area = a * a;
            int perimeter = 4 * a;
            Console.WriteLine($"The area of the square with side length {a} is {area} and its perimeter equals {perimeter}\n");
            Console.WriteLine("Press 'ENTER' to go to the next Task... ");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter)
            {

            }
        }
    }
}
