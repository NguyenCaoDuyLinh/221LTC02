using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("nhập a1, b1, c1: ");
            string a1 = Console.ReadLine();
            float a1_134 = float.Parse(a1);
            string b1 = Console.ReadLine();
            float b1_134 = float.Parse(b1);
            string c1 = Console.ReadLine();
            float c1_134 = float.Parse(c1);

            Console.Write("nhập a2, b2, c2: ");
            string a2 = Console.ReadLine();
            float a2_134 = float.Parse(a2);
            string b2 = Console.ReadLine();
            float b2_134 = float.Parse(b2);
            string c2 = Console.ReadLine();
            float c2_134 = float.Parse(c2);

            float D_134 = a1_134 * b2_134 - a2_134 * b1_134;
            if(D_134 != 0)
            {
                Console.WriteLine("Thỏa công thức Cramer");
                float Dx_134 = (float)Math.Round(c1_134 * b2_134 - b1_134 * c2_134, 3);
                float Dy_134 = (float)Math.Round(a1_134 * c2_134 - a2_134 * c1_134, 3);
                float x_134 = Dx_134 / D_134;
                float y_134 = Dy_134 / D_134;
                Console.Write("Giá trị x và y: {0}, {1}", x_134, y_134);
            }
            else
            {
                Console.WriteLine("Không thỏa công thức Cramer");
            }
            Console.ReadKey();
        }
    }
}
