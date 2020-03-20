using System;

namespace _3
{
    class Program
    {
        static void InputName(string[] s)
        {
            Console.Write("Ho : ");
            s[0] = Console.ReadLine();
            Console.Write("Ten Dem : ");
            s[1] = Console.ReadLine();
            Console.Write("Ten : ");
            s[2] = Console.ReadLine();
            Console.Write("NamSinh : ");
            s[3] = Console.ReadLine();
        }

        static void Output(string[] s)
        {
            Console.WriteLine("Ho : {0}",s[0]);
            Console.WriteLine("Ten Dem : {0}",s[1]);
            Console.WriteLine("Ten : {0}",s[2]);
            Console.WriteLine("NamSinh : {0}",s[3]);
        }

        static void GetAge(string[] s)
        {
            int t = DateTime.Now.Year - int.Parse(s[3]);
            Console.WriteLine("{0} Tuoi", t);
        }

        static void Main(string[]a args)
        {
            string[] s;
            s = new string[4];
            InputName(s);
            Output(s);
            GetAge(s);

            Console.ReadKey();
        }
    }
}
