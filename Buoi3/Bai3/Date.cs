using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3
{
    class Date
    {
        int ngay;
        int thang;
        int nam;

        public int Ngay { get => ngay; set => ngay = value; }
        public int Thang { get => thang; set => thang = value; }
        public int Nam { get => nam; set => nam = value; }

        public Date() { }
        public Date(int ngay , int thang, int nam)
        {
            this.ngay = ngay;
            this.thang = thang;
            this.nam = nam;
        }

        public void Nhap()
        {
            Console.WriteLine("Ngay : ");
            Ngay = int.Parse(Console.ReadLine());
            Console.WriteLine("Thang : ");
            Thang = int.Parse(Console.ReadLine());
            Console.WriteLine("Nam : ");
            Nam = int.Parse(Console.ReadLine());
        }

        public void GetDate()
        {
            Console.Write(ngay + "/" + thang + "/" + nam+"\n");
        }
    }
}
