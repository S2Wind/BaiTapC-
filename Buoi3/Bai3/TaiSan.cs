using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3
{
    class TaiSan
    {
        string tenTaiSan;
        int soLuong;
        string tinhTrang;

        public string TenTaiSan { get => tenTaiSan; set => tenTaiSan = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }

        public void Nhap()
        {
            Console.WriteLine("Nhap Ten Tai San : ");
            this.TenTaiSan = Console.ReadLine();
            Console.WriteLine("Nhap So Luong : ");
            this.SoLuong = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Tinh Trang : ");
            this.TinhTrang = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.WriteLine("Ten Tai San : " + this.TenTaiSan);
            Console.WriteLine("So Luong : " + this.SoLuong);
            Console.WriteLine("Tinh Trang : " + this.TinhTrang);
        }
    }
}
