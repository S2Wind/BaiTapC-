using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class LopHoc
    {
        Leader leader;
        int soLuongHocVien;
        HocVien[] hocVien;

        public LopHoc()
        {
            Leader = new Leader();

            SoLuongHocVien = 1;

            HocVien[0] = new HocVien();
        }

        public LopHoc(int soluong)
        {
            Leader = new Leader();
            this.SoLuongHocVien = soluong;
            HocVien = new HocVien[soLuongHocVien];
            for (int i = 0; i < SoLuongHocVien; i++)
                HocVien[i] = new HocVien();
        }

        public LopHoc(Leader leader,int soluong,HocVien[] hocVien)
        {
            this.Leader = leader;
            this.SoLuongHocVien = soluong;
            for (int i = 0; i < soluong; i++)
            {
                this.HocVien[i] = new HocVien();
                this.HocVien[i] = hocVien[i];
            }
        }

        public void Nhap(int soLuong)
        {
            Console.WriteLine("Nhap leader : ");
            leader.HoTen = Console.ReadLine();
            leader.QueQuan = Console.ReadLine();
            leader.GioiTinh = ((Console.ReadLine() == "Nam")?SinhVienHaUi.Sex.Nam:SinhVienHaUi.Sex.Nu);
            leader.DocToanThan = (Console.ReadLine()=="true")?true:false;
            leader.ChucVu = Console.ReadLine();
            Console.WriteLine("Nhap hoc vien : ");
            for(int i = 0; i < soLuong;i++)
            {
                Console.WriteLine(i + 1);
                hocVien[i].HoTen = Console.ReadLine();
                hocVien[i].QueQuan = Console.ReadLine();
                hocVien[i].GioiTinh = ((Console.ReadLine() == "Nam") ? SinhVienHaUi.Sex.Nam : SinhVienHaUi.Sex.Nu);
                hocVien[i].DocToanThan = (Console.ReadLine() == "true") ? true : false;
                hocVien[i].CongNo = int.Parse(Console.ReadLine());
            }
        }

        public void ThanhToanCongNo(string tenHocSinh,int ThanhToan)
        {
            int vt = -1 ;
            for(int i = 0; i < soLuongHocVien; i++)
            {
                if(tenHocSinh == hocVien[i].HoTen)
                {
                    vt = i;
                    break;
                }
            }
            if (vt == -1) Console.WriteLine("Khong tim thay");
            else
            {
                hocVien[vt].ThanhToanCongNo(ThanhToan);
            }
        }
        public void NgauNhienCrush()
        {
            HocVien[] hs = new HocVien[soLuongHocVien];
            int run = -1;
            for (int i = 0; i<soLuongHocVien;i++)
            {
                hs[i] = new HocVien();
                if(hocVien[i].DocToanThan == true)
                {
                    hs[++run] = HocVien[i];
                }
            }
            Random random = new Random();
            int j = random.Next(0, run);
            hs[j].xuat();
        }

        public void CoNguoiYeuLaMatTien()
        {
            for (int i = 0; i < soLuongHocVien; i++)
            {
                if (hocVien[i].DocToanThan == false)
                {
                    hocVien[i].ThanhToanCongNo(-5000);
                    Console.WriteLine("Da Tang Tien");
                }
            }
        }


        public int SoLuongHocVien { get => soLuongHocVien; set => soLuongHocVien = value; }
        internal Leader Leader { get => leader; set => leader = value; }
        internal HocVien[] HocVien { get => hocVien; set => hocVien = value; }
    }
}
