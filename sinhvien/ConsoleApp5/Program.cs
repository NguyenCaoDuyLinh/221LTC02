using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        List<sinhvien> dssv = null;
        struct sinhvien{
            public int msv134;
            public string tensv134;
            public double toan134;
            public double ly134;
            public double hoa134;
            public int gioitinh134;
        }
        enum gioitinh{
            nam,
            nữ
        }
        static void thongtin(ref sinhvien sv)
        {
            Console.Write("Nhập mã sinh viên: ");
            sv.msv134 = int.Parse(Console.ReadLine());
            Console.Write("Nhập tên sinh viên: ");
            sv.tensv134 = Console.ReadLine();
            Console.Write("Nhập giới tính sinh viên: ");
            sv.gioitinh134 = int.Parse(Console.ReadLine());
            Console.Write("Nhập điểm toán sinh viên: ");
            sv.toan134 = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm lý sinh viên: ");
            sv.ly134 = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm toán sinh viên: ");
            sv.hoa134 = double.Parse(Console.ReadLine());
            
        }
        static void xuat(sinhvien sv)
        {
            Console.WriteLine("Mã sinh viên: " + sv.msv134);
            Console.WriteLine("Tên sinh viên: " + sv.tensv134);
            if(sv.gioitinh134 == 0)
                Console.WriteLine("Giới tính: " + gioitinh.nam);
            else
                Console.WriteLine("Giới tính: " + gioitinh.nữ);
            Console.WriteLine("Điểm toán: " + sv.toan134);
            Console.WriteLine("Điểm lý: " + sv.ly134);
            Console.WriteLine("Điểm hóa: " + sv.hoa134);
            Console.WriteLine("Điểm trung bình: " + diemtb(sv));
        }
        static double diemtb(sinhvien sv)
        {
            return (sv.toan134 + sv.ly134 + sv.hoa134) / 3;
        }
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<sinhvien> dssv = new List<sinhvien>();
            sinhvien sv1 = new sinhvien();
            thongtin(ref sv1);
            dssv.Add(sv1);
            Console.Write("----------------");
            xuat(sv1);
            Console.Write("nhập tên sv cần tìm: ");
            string name = Console.ReadLine();
            foreach(sinhvien sv in dssv)
            {
                if (sv.tensv134.ToUpper().Contains(name.ToUpper()))
                    {
                    Console.WriteLine("Mã sinh viên: " + sv.msv134);
                    Console.WriteLine("Điểm toán: " + sv.toan134);
                    Console.WriteLine("Điểm lý: " + sv.ly134);
                    Console.WriteLine("Điểm hóa: " + sv.hoa134);
                    Console.WriteLine("Điểm trung bình: " + diemtb(sv));
                }
            }
            Console.ReadKey();
            
            
        }
    }
}
