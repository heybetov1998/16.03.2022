using System;

namespace _16._03._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            while (number != 0)
            {
                number /= 10;
                counter++;
            }
            Console.WriteLine("Ededin mertebelerinin sayi: " + counter);
        }
    }
}
