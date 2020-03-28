using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3
{
    class NhanVien
    {
        string tenNhanVien;
        string chucVu;

        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }

        public NhanVien()
        {
            tenNhanVien = null;
            chucVu = null;
        }

        public NhanVien(string tenNhanVien , string chucVu)
        {
            this.tenNhanVien = tenNhanVien;
            this.chucVu = chucVu;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap ten Nhan Vien : ");
            this.tenNhanVien = Console.ReadLine();
            Console.WriteLine("Chuc vu : "); ;
            this.chucVu = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.WriteLine("Ten Nhan Vien : "+ TenNhanVien);
            Console.WriteLine("Chuc vu : "+ ChucVu);
        }
    }
}
