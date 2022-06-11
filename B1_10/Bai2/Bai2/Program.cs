using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("nhập x của điểm A: ");
            string d134A = Console.ReadLine();
            float x134A = float.Parse(d134A);
            Console.Write("nhập y của điểm A: ");
            string d2A134 = Console.ReadLine();
            float yA134 = float.Parse(d2A134);
            Console.Write("nhập x của điểm B: ");
            string d134B = Console.ReadLine();
            float xB134 = float.Parse(d134B);
            Console.Write("nhập y của điểm B: ");
            string d2B134 = Console.ReadLine();
            float yB134 = float.Parse(d2B134);
            float distanceAB134 = (float)Math.Round(Math.Sqrt(Math.Pow(xB134 - x134A, 2) + Math.Pow(yB134 - yA134, 2)), 3);
            Console.Write("Khoảng cách của 2 điểm A và B là {0}", distanceAB134);

            Console.ReadKey();
        }
    }
}
