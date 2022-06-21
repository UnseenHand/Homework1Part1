using System;

namespace Homework1Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The square's side value : ");
            int a = Convert.ToInt32(Console.ReadLine());
            int area = a * a;
            int perimeter = 4 * a;
            Console.WriteLine($"The area of the square with length {a} is {area} and the perimeter is {perimeter}");
        }
    }
}
