using System;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int s1=0, s2=0, s3=0;
            
            for(int i = 1;i<=n;i++)
            {
                s1 += i;
                s2 *= i;
                s3 += (n - 1) * n;
            }

            Console.WriteLine("S1 = {0} \nS2 = {1} \nS3 = {2}", s1, s2, s3);

            Console.ReadKey();
        }
    }
}
