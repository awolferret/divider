using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(1, 28);
            Console.WriteLine(number);

            for (int i = number; i < 1000 & i > 100 ; i += number)
            {
                Console.WriteLine(i);
            }
        }
    }
}