using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3
{
    class Phieu
    {
        string maPhieu;
        Date ngayKiemKe;
        int soLuongDaThongKe;
        NhanVien nv;
        PhongBan phong;
        TaiSan[] taiSan;

        public string MaPhieu { get => maPhieu; set => maPhieu = value; }
        public int SoLuongDaThongKe { get => soLuongDaThongKe; set => soLuongDaThongKe = value; }

        public Phieu()
        {
            maPhieu = null;
            ngayKiemKe = new Date();
            soLuongDaThongKe = 0;
            nv = new NhanVien();
            phong = new PhongBan();
            taiSan = new TaiSan[soLuongDaThongKe];
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap Ma Phieu : " + MaPhieu);
            MaPhieu = Console.ReadLine();
            Console.WriteLine("Ngay Kiem ke : ");
            ngayKiemKe.Nhap();
            Console.WriteLine("So Luong thong ke : ");
            SoLuongDaThongKe = int.Parse(Console.ReadLine());
            nv.Nhap();
            phong.Nhap();
            taiSan = new TaiSan[soLuongDaThongKe];
            for(int i = 0; i < soLuongDaThongKe; i++)
            {
                Console.WriteLine("Nhap Hang " + i);
                taiSan[i] = new TaiSan();
                taiSan[i].Nhap();
            }
        }

        public void Xuat()
        {
            Console.WriteLine("Ma Phieu : " + MaPhieu);
            Console.WriteLine("Ngay Kiem ke : ");
            ngayKiemKe.GetDate();
            Console.WriteLine("So Luong thong ke : ");
            nv.Xuat();
            phong.Xuat();
            int tong = 0;
            for (int i = 0; i < soLuongDaThongKe; i++)
            {
                Console.WriteLine("Hang " + i);
                taiSan[i].Xuat();
                tong += taiSan[i].SoLuong;
            }
            Console.WriteLine("TongSoLuong " + tong);
        }
    }
}
