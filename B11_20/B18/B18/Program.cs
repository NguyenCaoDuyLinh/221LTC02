using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
        nhap:
            Console.Write("nhập số giờ: ");
            string hour = Console.ReadLine();
            int hours_134 = int.Parse(hour);
            if (hours_134 < 0)
            {
                Console.Write("nhập sai\n");
                goto nhap;
            }
            else
            {
                int day_134 = hours_134 / 24;
                int exhours_134 = hours_134 % 24;
                int week_134 = day_134 / 7;
                int exday_134 = day_134 % 7;
                Console.Write("{0} tuần, {1} ngày, {2} giờ", week_134, exday_134, exhours_134);
            }
            Console.ReadKey();
        }
    }
}
