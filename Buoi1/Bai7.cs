using System;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            int GiaiThua(int a)
            {
                if (a == 0)
                    return 1;
                else
                {
                    int tmp = 1;
                    for (int i = 1; i <= a; i++)
                        tmp *= i;
                    return tmp;
                }
            }

            int LuyThuy(int a,int n)
            {
                int tmp = a;
                if (n == 0) return 1;
                for (int i = 1; i <= n; i++)
                    tmp *= a;
                return tmp;
            }

            int x = int.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            float kq = 0;

            for(int n = 0;Math.Abs(LuyThuy(x,n)/GiaiThua(n)) < c; n++)
            {
                kq += LuyThuy(x,n) / GiaiThua(n);
            }

            Console.WriteLine("Kq : ex = {0}", kq);
            Console.ReadKey();
        }
    }
}
