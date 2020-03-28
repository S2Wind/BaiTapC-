using System;

namespace Bai1
{
    class HANGHOA
    {
        string maHang;
        string tenHang;
        int donGia;
        int sl;

        public string MaHang { get => maHang; set => maHang = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public int Sl { get => sl; set => sl = value; }

        public void Nhap()
        {
            Console.Write("Nhap Ma Hang : ");
            this.MaHang = Console.ReadLine();
            Console.Write("Nhap Ten Hang : ");
            this.TenHang = Console.ReadLine();
            Console.Write("Nhap Don Gia : ");
            this.DonGia = int.Parse(Console.ReadLine());
            Console.Write("Nhap So Luong : ");
            this.Sl = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.Write("Ma Hang : " + this.MaHang + "-- ");
            Console.Write("Ten Hang : " + this.TenHang + "-- ");
            Console.Write("Don Gia : " + this.DonGia + " -- So Luong : " + this.Sl);
            Console.Write("=> Thanh Tien : "+this.DonGia * this.Sl);
            Console.Write("\n");
        }

        public static void SapXep(HANGHOA[] a , int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                int thanh1 = a[i].DonGia * a[i].Sl;
                for (int j = i + 1; j < n; j++)
                {
                    int thanh2 = a[j].DonGia * a[j].sl;
                    if (thanh1 > thanh2)
                    {
                        HANGHOA tmp = a[j];
                        a[j] = a[i];
                        a[i] = tmp;
                        thanh1 = thanh2;
                    }
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap : ");
            int n = int.Parse(Console.ReadLine());
            HANGHOA[] hh = new HANGHOA[n];
            for(int i = 0; i <n;i++)
            {
                hh[i] = new HANGHOA();
                hh[i].Nhap();
            }

            HANGHOA.SapXep(hh, n);

            for (int i = 0; i < n; i++)
            {
                hh[i].Xuat();
            }

            Console.ReadKey();
        }
    }

}
