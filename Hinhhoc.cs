using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dahinh
{
    class Hinhhoc
    {
        public virtual void xuat()
        {
            Console.Write("Hình Gì");
        }
        
        class  tamgiac : Hinhhoc{
            public override void xuat()
            {
                Console.Write("Hình Tam Giác");
            }
        }
        class tugiac : Hinhhoc
        {
            public override void xuat()
            {
                Console.Write("Hình Tứ Giác");
            }
        }
        class hinhbinhhanh : Hinhhoc
        {
            public override void xuat()
            {
                Console.Write("Hình Bình Hành");
            }
        }
        class hinhchunhat : Hinhhoc
        {
            public override void xuat()
            {
                Console.Write("Hình Chữ nhật");
            }
        }
        class vuong : Hinhhoc
        {
            public override void xuat()
            {
                Console.Write("Hình vuông");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Chọn hình");
            switch (Console.ReadLine())
            {
                case "Hinh vuong":
                    Hinhhoc hvuong = new vuong();
                    hvuong.xuat();
                    break;
            
                case "Hinh tam giac":
                    Hinhhoc tg = new tamgiac();
                    tg.xuat();
                    break;
                case "Hinh chu nhat":
                    Hinhhoc cn = new hinhchunhat();
                    cn.xuat();
                    break;
                case "Hinh binh hanh":
                    Hinhhoc hbh = new hinhbinhhanh();
                    hbh.xuat();
                    break;
                case "Hinh tu giac":
                    Hinhhoc tug = new tugiac();
                    tug.xuat();
                    break;
                default :
                    Console.WriteLine("Chọn hình");
                    break;
            }
            
            Console.ReadKey();
        }
    }
}
