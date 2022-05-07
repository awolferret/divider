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

            for (int i = number; i < 1000; i += number)
            {
                if (i > 99)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}