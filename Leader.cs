using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class Leader : SinhVienHaUi
    {
        string chucVu;

        public Leader()
        {
            HoTen = QueQuan = ChucVu = null;
            GioiTinh = Sex.Null;
            DocToanThan = true;
        }

        public Leader(string hoten,string quequan,Sex gioitinh,bool doctoanthan,string chucvu):base(hoten,quequan,gioitinh,doctoanthan)
        {
            this.HoTen = hoten;
            this.QueQuan = quequan;
            this.GioiTinh = gioitinh;
            this.DocToanThan = doctoanthan;
            this.ChucVu = chucVu;
        }

        public string ChucVu { get => chucVu; set => chucVu = value; }
    }
}
