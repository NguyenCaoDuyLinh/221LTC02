using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            nhaplai:
            Console.Write("Nhập số: ");
            string x = Console.ReadLine();
            int a_134 = int.Parse(x);
            if(a_134 < 0)
            {
                Console.Write("Nhập sai\n");
                goto nhaplai;
            }
            else
            {
                int dem_134 = 0, tong_134 = 0;
                Console.WriteLine("các ước số là: ");
                for (int i = 1; i <= a_134; i++)
                {
                    if (a_134 % i == 0)
                    {
                        dem_134 += 1;
                        Console.Write(i + " ");
                        tong_134 += i;
                    }
                }
                Console.Write("\nCó {1} ước, tổng các ước số là: {0}", tong_134, dem_134);
            }
            Console.ReadKey();
        }
    }
}
