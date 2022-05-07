using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(1, 28);
            int count = 0;
            int minValue = 99;
            int maxValue = 1000;

            for (int i = number; i < maxValue; i += number)
            {

                if (i > minValue)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}