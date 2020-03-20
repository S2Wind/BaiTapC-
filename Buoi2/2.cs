using System;

namespace _2
{
    class Program
    {

        static void Input(out float a , out float x ,out int n)
        {
            Console.WriteLine("A = ");
            a = float.Parse(Console.ReadLine());
            
            do
            {
                Console.WriteLine("X > 0 = ");
                x = float.Parse(Console.ReadLine());
            } while (x <= 0);

            do
            {
                Console.WriteLine("n [5,20] = ");
                n = int.Parse(Console.ReadLine());
            } while (n > 20 || n < 5);
        }

        static float T(float x , int k)
        {
            for(int i = 1; i <= k; i++)
            {
                x *= x;
            }
            x = (float)Math.Sqrt(x);
            return x;
        }

        static void S(float a , float x, int n)
        {
            float kq = a;
            int t = -1;
            for(int i = 1; i<=n;i++)
            {
                kq += (T(x, i) / (n - i + 1))*t;
                t *= -1;
            }
            Console.WriteLine(kq);
        }


        static void Main(string[] args)
        {
            float a, x;
            int n;
            Input(out a,out x,out n);
            S(a, x, n);
            Console.ReadKey();
        }
    }
}
