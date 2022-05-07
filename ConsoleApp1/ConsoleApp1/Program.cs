using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = 0;
            int minValue = 99;
            int maxValue = 1000;
            int minRange = 1;
            int maxRange = 28;
            Random random = new Random();
            int number = random.Next(minRange, maxRange);

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