using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3
{
    class PhongBan
    {
        string tenPhongBan;
        string maPhongBan;
        string truongPhong;

        public string TenPhongBan { get => tenPhongBan; set => tenPhongBan = value; }
        public string MaPhongBan { get => maPhongBan; set => maPhongBan = value; }
        public string TruongPhong { get => truongPhong; set => truongPhong = value; }

        public void Nhap()
        {
            Console.WriteLine("Nhap Ten Phong ban : ");
            TenPhongBan = Console.ReadLine();
            Console.WriteLine("Ma Phong Ban : ");
            MaPhongBan = Console.ReadLine();
            Console.WriteLine("Truong phong : ");
            TruongPhong = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.WriteLine("Ten Phong Ban : " + TenPhongBan);
            Console.WriteLine("Ma Phong Ban : " + MaPhongBan);
            Console.WriteLine("Truong Phong : " + TruongPhong);
;       }
    }
}
