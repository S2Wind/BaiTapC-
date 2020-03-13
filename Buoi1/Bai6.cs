using System;

namespace Bai6
{
    class Program
    {

        static void Main(string[] args)
        {
            bool CheckIfPrimary(int a)
            {
                if (a == 1) return false;
                for (int i = 2; i <= Math.Sqrt(a); i++)
                {
                    if (a % i == 0)
                        return false;
                }
                return true;
            }

            int n = int.Parse(Console.ReadLine());

            Console.Write("n = ");

            if (CheckIfPrimary(n))
            {
                Console.Write(n);
            }
            else 
            {
                int tmp = n;
                for(int i = 2; i <= Math.Sqrt(n);i++)
                {

                    while(tmp != 1 && tmp%i == 0)
                    {
                        tmp /= i;
                        if (tmp != 1)
                            Console.Write(i + "*");
                        else Console.Write(i);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
