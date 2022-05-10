using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace songuyen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n134 = new int[10];
            Console.OutputEncoding = Encoding.UTF8;
            for (int i134 = 0; i134 < 10; i134++)
            {
                n134[i134] = int.Parse(Console.ReadLine());
            }
            Console.Write("Giá trị lớn nhất: {0}", lonnhat(n134));
            Console.Write("Giá trị nhỏ nhất: {0}", nhonhat(n134));
            Console.Write("Sắp xếp tăng dần");
            sapxeptangdan(ref n134);
            Console.Write("Sắp xếp giảm dần");
            sapxepgiamdan(ref n134);
            Console.ReadKey();

        }
        static int lonnhat(int[] a134)
        {
            int i134;
            int max = a134[0];
            for (i134 = 1; i134 < 10; i134++)
            {
                if (max < a134[i134])
                    max = a134[i134];
            }
            return max;
        }
        static int nhonhat(int[] a134)
        {
            int i134;
            int min134 = a134[0];
            for (i134 = 1; i134 < 10; i134++)
            {
                if (min134 > a134[i134])
                    min134 = a134[i134];
            }
            return min134;
        }
        static void sapxeptangdan(ref int[] a134)
        {
            int i134, j134, tmp134;
            for (i134 = 0; i134 < 10; i134++)
            {
                for (j134 = i134 + 1; j134 < 10; j134++)
                {
                    if (a134[j134] < a134[i134])
                    {

                        tmp134 = a134[i134];
                        a134[i134] = a134[j134];
                        a134[j134] = tmp134;
                    }
                }
            }
        }
        static void sapxepgiamdan(ref int[] a134)
        {
            int i134, j134, tmp134;
            for (i134 = 0; i134 < 10; i134++)
            {
                for (j134 = i134 + 1; j134 < 10; j134++)
                {
                    if (a134[j134] > a134[i134])
                    {

                        tmp134 = a134[i134];
                        a134[i134] = a134[j134];
                        a134[j134] = tmp134;
                    }
                }
            }
        }
    }
}
