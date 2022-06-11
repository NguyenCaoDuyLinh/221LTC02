using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("nhập diện tích hình cầu: ");
            string a134 = Console.ReadLine();
            float Scau134 = float.Parse(a134);
            if(Scau134 <= 0)
            {
                Console.Write("nhập sai diện tích hình cầu");
            }
            else
            {
                float Rcau134 = (float)Math.Sqrt(Scau134 / (4 * Math.PI));
                float Vcau134 = (float)Math.Round((4 * Math.PI * Math.Pow(Rcau134, 3) / 3), 4);
                Console.Write("thể tích hình cầu là: {0}", Vcau134);
            }
            Console.ReadKey();
        }
    }
}
