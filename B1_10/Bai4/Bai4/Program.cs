using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập cạnh I: ");
            string a134 = Console.ReadLine();
            float c1134 = float.Parse(a134);
            Console.Write("Nhập cạnh II: ");
            string b134 = Console.ReadLine();
            float c2134 = float.Parse(b134);
            Console.Write("Nhập cạnh III: ");
            string c134 = Console.ReadLine();
            float c3134 = float.Parse(c134);
            if(c1134 <= 0 || c2134 <= 0 || c3134 <= 0)
            {
                Console.Write("Nhập sai độ dài các cạnh");
            }
            else 
            if(c1134 + c2134 > c3134 && c1134 + c3134 > c2134 && c2134 + c3134 > c1134)
            {
                if(c1134 == c2134 && c2134 == c3134 && c1134 == c3134)
                {
                    Console.Write("tam giác đều");
                }
                else
                if (c1134 == c2134 || c2134 == c3134 || c1134 == c3134)
                {
                    if (Math.Pow(c1134, 2) + Math.Pow(c2134, 2) == Math.Pow(c3134, 2)
                    || Math.Pow(c1134, 2) + Math.Pow(c3134, 2) == Math.Pow(c2134, 2)
                    || Math.Pow(c2134, 2) + Math.Pow(c3134, 2) == Math.Pow(c1134, 2))
                    {
                        Console.Write("tam giác vuông cân");
                    }
                    else
                    {
                        Console.Write("tam giác cân");
                    }
                }
                else
                if (Math.Pow(c1134, 2) + Math.Pow(c2134, 2) == Math.Pow(c3134, 2) 
                    || Math.Pow(c1134, 2) + Math.Pow(c3134, 2) == Math.Pow(c2134, 2)
                    || Math.Pow(c2134, 2) + Math.Pow(c3134, 2) == Math.Pow(c1134, 2))
                {
                    Console.Write("tam giác vuông");
                }
                else
                {
                    Console.Write("tam giác thường");
                }
                float p134 = (c1134 + c2134 + c3134) / 2;
                float S134 = (float)Math.Round(Math.Sqrt(p134 * (p134 - c1134) * (p134 - c2134) * (p134 - c3134)), 3);
                Console.Write("\nDiện tích tam giác là: {0}", S134);
            }
            else
            {
                Console.Write("không phải là 3 cạnh 1 tam giác");
            }                  
            Console.ReadKey();
        }
    }
}
