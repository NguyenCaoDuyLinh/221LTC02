using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("nhập tọa độ x, y tâm C: ");
            string d134 = Console.ReadLine();
            float xC134 = float.Parse(d134);
            string d2134 = Console.ReadLine();
            float yC134 = float.Parse(d2134);

            Console.Write("nhập bán kính R: ");
            string bkinh = Console.ReadLine();
            float R134 = float.Parse(bkinh);

            Console.Write("nhập tọa độ x, y điểm M: ");
            string d1M134 = Console.ReadLine();
            float xM134 = float.Parse(d1M134);
            string d2M134 = Console.ReadLine();
            float yM134 = float.Parse(d2M134);

            float kCachOM134 = (float)Math.Round(Math.Pow(xM134 - xC134, 2) + Math.Pow(yM134 - yC134, 2), 4);
            float kCachR134 = (float)Math.Pow(R134, 2);
            if(R134 <= 0)
            {
                Console.Write("nhập sai độ dài bán kính");
            }
            else if(kCachOM134 < kCachR134)
            {
                Console.Write("điểm M nằm trong đường tròn");
            }
            else if(kCachOM134 == kCachR134)
            {
                Console.Write("điểm M nằm trên đường tròn");
            }
            else
            {
                Console.Write("điểm M nằm ngoài đường tròn");
            }
            Console.ReadLine();
        }
    }
}
