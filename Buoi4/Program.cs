using System;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {

            LopHoc lop = new LopHoc(5);
            lop.Nhap(5);

            lop.ThanhToanCongNo("Phan Dac Son",1000000);
            lop.NgauNhienCrush();
            lop.CoNguoiYeuLaMatTien();

            Console.ReadKey();

        }
    }
}
