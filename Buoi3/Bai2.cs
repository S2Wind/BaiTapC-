using System;

namespace Bai2
{
    class TamThuc
    {
        float a;
        float b;
        float c;

        public float A { get => a; set => a = value; }
        public float B { get => b; set => b = value; }
        public float C { get => c; set => c = value; }

        public TamThuc()
        {
            a = b = c = 0;
        }
        public TamThuc(float a, float b , float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
       
        public void Xuat()
        {
            Console.WriteLine(a + "X2 " + (b < 0 ? b.ToString(): ("+"+b))  + "X " + (c<0 ? c.ToString():"+"+c));
        }

        public static TamThuc operator ~(TamThuc q)
        {
            TamThuc kq = new TamThuc();
            kq.a = -q.a;
            kq.b = -q.b;
            kq.c = -q.c;
            return kq;
        }

        public static TamThuc operator +(TamThuc m,TamThuc n)
        {
            TamThuc tong = new TamThuc();
            tong.a = m.a + n.a;
            tong.b = m.b + n.b;
            tong.c = m.c + n.c;
            return tong;
        }
        public static TamThuc operator -(TamThuc m, TamThuc n)
        {
            TamThuc hieu = new TamThuc();
            hieu.a = m.a - n.a;
            hieu.b = m.b - n.b;
            hieu.c = m.c - n.c;
            return hieu;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TamThuc tamthuc1 = new TamThuc(1, 1, 1);
            tamthuc1.Xuat();
            TamThuc tamthuc2 = new TamThuc(5, 1, 7);
            tamthuc2.Xuat();
            TamThuc tong = tamthuc1 + tamthuc2;
            TamThuc hieu = tamthuc2 - tamthuc1;
            TamThuc dao = ~tamthuc1;
            Console.Write("Tong : ");
            tong.Xuat();
            Console.Write("Hieu : ");
            hieu.Xuat();
            Console.Write("Dao tam thuc 1 : ");
            dao.Xuat();


            Console.ReadKey();
        }
    }
}
