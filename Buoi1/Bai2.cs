using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            do
            {
                Console.WriteLine("Nhap :");
                a = float.Parse(Console.ReadLine());
                b = float.Parse(Console.ReadLine());
                c = float.Parse(Console.ReadLine());
            } while (a <= 0 || b <= 0 || c <= 0);

            if(a + b > c && a + c > b && b + c > a)
            {
                
                Console.WriteLine("La 3 canh tam giac!");
                if (a == b && b == c)
                {
                    Console.WriteLine("Tam giac deu!");
                }
                else
                {
                    bool can = false, vuong = false;
                    if (a == b || b == c || c == a)
                    {
                        can = true;
                    }

                    if (a * a + b * b == c * c || a * a + c * c == b * b || c * c + b * b == a * a)
                    {
                        vuong = true;
                    }
                    if(can && vuong)
                    {
                        Console.WriteLine("Vuong Can!");
                    }
                    else
                    {
                        if (can && !vuong)
                            Console.WriteLine("Can!");
                        else
                            if (!can && vuong)
                            Console.WriteLine("Vuong!");
                        else
                            Console.WriteLine("Thuong!");

                    }
                }
            }

            Console.ReadKey();
        }
    }
}
