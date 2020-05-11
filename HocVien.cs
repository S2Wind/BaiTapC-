using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class HocVien:SinhVienHaUi
    {
        int congNo;

        public HocVien()
        {
            congNo = 10000;
            HoTen = QueQuan  = null;
            GioiTinh = Sex.Null;
            DocToanThan = true;
        }
        public HocVien(string hoten,string queQuan,Sex gioiTinh,bool docToanThan,int congNo):base(hoten,queQuan,gioiTinh,docToanThan)
        {
            this.HoTen = hoten;
            this.QueQuan = queQuan;
            this.GioiTinh = gioiTinh;
            this.DocToanThan = docToanThan;
            this.CongNo = congNo;
        }

        public void ThanhToanCongNo(int soTien)
        {
            CongNo -= soTien;
            if(CongNo < 0)
            {
                CongNo = 0;
                Console.WriteLine("So tien du : " + (soTien - CongNo));
            }
            else
            {
                Console.WriteLine("Da Thanh toan thanh cong !");
            }
        }

        public int CongNo { get => congNo; set => congNo = value; }
    }
}
