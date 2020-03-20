using System;

namespace _1
{
    class Program
    {
        static void Input(out int n)
        {
            n = int.Parse(Console.ReadLine());
        }

        static void InputArray(int[] a, int n)
        {
            for(int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        static bool IsPrime(int x)
        {
            if (x == 1) return false;
            for(int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }

        static void ArrayOutput(int[] a , int n)
        {
            for(int i = 0; i< n; i++)
            {
                if (IsPrime(a[i]))
                    Console.Write(a[i] + ' ');
            }
        }
        
        static void Main(string[] args)
        {
            int n;
            Input(out n);
            int[] a = new int[n];
            InputArray(a, n);
            ArrayOutput(a, n);

            Console.ReadKey();
        }
    }
}
