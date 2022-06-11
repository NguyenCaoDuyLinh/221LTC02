using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            nhap:
            Console.Write("Nhập số: ");
            string s = Console.ReadLine();
            int so_134 = int.Parse(s), gan_134 = 0;
            if(so_134 <= 0)
            {
                Console.Write("nhập sai\n");
                goto nhap;
            }
            else
            {
                int sum = 0;
                for (int i = 1; i <= so_134; i++)
                {

                    if (so_134 % i == 0)
                    {
                        sum += 1;
                        gan_134 = i;
                    }
                }
                if (sum == 2)
                {
                    
                    Console.Write("{0} là số nguyên tố", gan_134);
                }
                else
                {
                    Console.Write("{0} không phải số nguyên tố\nsố nguyên tố gần nhất: ", gan_134);
                    for (int i = so_134; i > 1; i--)
                    {
                        int sum1 = 0;
                        for (int j = 1; j <= i; j++)
                        {
                            if (i % j == 0)
                            {
                                sum1 += 1;
                            }
                        }
                        if (sum1 == 2)
                        {
                            Console.Write(i + " ");
                            break;
                        }
                    }
                }
            }        
            Console.ReadKey();
        }
    }
}
