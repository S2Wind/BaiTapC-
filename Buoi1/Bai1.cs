using System;

namespace BaiTap1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;
            
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());

            var tmp = a;
            var arr = new int[] {a, b, c, d, e };

            foreach (int i in arr) 
            {
                if (i > tmp)
                    tmp = i;
            }
            int kq = a;

            foreach(int i in arr)
            {
                if(i>kq && i<tmp)
                {
                    kq = i;
                }
            }

            Console.WriteLine("So lon thu 2 la : {0}", kq);

            Console.ReadKey();
        }
    }
}
