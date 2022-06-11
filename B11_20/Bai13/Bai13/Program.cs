using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("nhập ngày, tháng, năm: ");
            string ngay = Console.ReadLine();
            int day_134 = int.Parse(ngay);
            string thang = Console.ReadLine();
            int month_134 = int.Parse(thang);
            string nam = Console.ReadLine();
            int year_134 = int.Parse(nam);
            if(year_134 < 1582)
            {
                Console.Write("lịch Gregorian bắt đầu từ năm 1582");
            }
            else
            if(month_134 < 1 || month_134 > 12)
            {
                Console.Write("nhập tháng sai");
            }
            else
            {
                int top;
                switch (month_134)
                {
                    case 4:
                        top = 30;
                        break;
                    case 6:
                        top = 30;
                        break;
                    case 9:
                        top = 30;
                        break;
                    case 11:
                        top = 30;
                        break;
                    case 2:
                        if (year_134 % 4 == 0 && year_134 % 100 != 0)
                        {
                            top = 29;
                        }
                        else
                        {
                            top = 28;
                        }
                        break;
                    default:
                        top = 31;
                        break;
                }
                if (day_134 < 1 || day_134 > top)
                {
                    Console.Write("nhập sai ngày, nhập lại");
                }
                else
                {
                    Console.Write("ngày tháng năm hợp lệ\n");
                    int a_134 = (14 - month_134) / 12;
                    int y_134 = year_134 - a_134;
                    int m_134 = month_134 + 12 * a_134 - 2;
                    int dayOfWeek_134 = (day_134 + y_134 + y_134 / 4 - y_134 / 100
                        + y_134 / 400 + (31 * m_134) / 12) % 7;
                    Console.Write("là thứ {0}", dayOfWeek_134 + 1);
                }
            }
            Console.ReadKey();
        }
    }
}
