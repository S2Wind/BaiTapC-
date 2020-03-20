using System;

namespace _4
{
    class Program
    {
        struct Date
        {
            public string Day;
            public string Month;
            public string Year;
        }

        struct Student
        {
            public int ID;
            public string Name;
            public Date DateOfBirth;
        }

        static void Input(ref Student s)
        {
            Console.WriteLine("ID : ");
            s.ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Name : ");
            s.Name = Console.ReadLine();
            Console.WriteLine("Day : ");
            s.DateOfBirth.Day = Console.ReadLine();
            Console.WriteLine("Month : ");
            s.DateOfBirth.Month = Console.ReadLine();
            Console.WriteLine("Year : ");
            s.DateOfBirth.Year = Console.ReadLine();
        }

        static void Output(Student[] s)
        {
            int n = s.Length;
            for(int i = 0; i <n;i++)
            {
                Console.WriteLine(s[i].ID);
                Console.WriteLine(s[i].Name);
                Console.WriteLine("Date of birth : " + s[i].DateOfBirth.Day + "/" + s[i].DateOfBirth.Month + "/" + s[i].DateOfBirth.Year);
            }
        }

        static void Arrangement(ref Student[] s)
        {
            int n = s.Length;
            for(int i = 0; i < n-1; i ++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if(int.Parse(s[i].DateOfBirth.Year) > int.Parse(s[j].DateOfBirth.Year))
                    {
                        Student temp = s[i];
                        s[i] = s[j];
                        s[j] = temp;
                    }
                }
            }
        }



        static void Main(string[] args)
        {
            Console.WriteLine("n = ");
            int n = int.Parse(Console.ReadLine());

            Student[] students = new Student[n];

            for(int i = 0; i < n; i ++)
            {
                Input(ref students[i]);
            }
            Arrangement(ref students);
            Output(students);
            Console.ReadKey();
        }
    }
}
