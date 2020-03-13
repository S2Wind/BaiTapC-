Baiusing System;

namespace B4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool isPrimary = true;

            if (n == 1) isPrimary = false;

            for(int i = 2; i <= Math.Sqrt(n); i++)
            {
                if(n%i == 0)
                {
                    isPrimary = false;
                    break;
                }
            }

            Console.WriteLine("n La So Nguyen to : {0}", isPrimary);
            Console.ReadKey();

        }
    }
}
