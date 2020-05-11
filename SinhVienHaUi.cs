using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace bai1
{
    class SinhVienHaUi
    {
        string hoTen;
        string queQuan;
        Sex gioiTinh;
        bool docToanThan;

        public enum Sex
        {
            Nam,
            Nu,
            Null
        };

        public SinhVienHaUi()
        {
            hoTen = null;
            queQuan = null;
            gioiTinh = Sex.Null;
            docToanThan = true;
        }

        public SinhVienHaUi(string hoten,string quequan,Sex gioitinh,bool doctoanthan)
        {
            this.HoTen = hoten;
            this.QueQuan = quequan;
            this.GioiTinh = gioiTinh;
            this.DocToanThan = doctoanthan;
        }

        public void xuat()
        {
            Console.WriteLine("Ho ten : " + HoTen);
            Console.WriteLine("Que Quan : " + QueQuan);
            Console.WriteLine("Gioi tinh " + GioiTinh);
        }

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        public bool DocToanThan { get => docToanThan; set => docToanThan = value; }
        internal Sex GioiTinh { get => gioiTinh; set => gioiTinh = value; }
    }
}
