using System;

namespace ConsoleApp1
{
    class Bai3
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write("Uoc cua {0} la : ", n);

            for(int i = 1;i<=n/2;i++)
            {
                if (n % i == 0)
                    Console.Write(i + " ");
            }

            Console.Write(n);

            Console.ReadKey();
        }
    }
}
