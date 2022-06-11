using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int a = 2;
            Console.WriteLine("{0}", a);
            refout(ref a);
            Console.WriteLine("{0}", a);
            outref(out a);
            Console.WriteLine("{0}", a);*/
            Console.Write("Nhap n: ");
            Random rd = new Random();
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for(int i= 0;i<n;i++)
            {
                a[i] = rd.Next(1,100);
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\nmax: {0}",max(a,n));
            Console.ReadKey();

            
        }
        static void refout(ref int a)
        {
            a--; 
        }
        static void outref(out int a)
        {
            a = 3;

        }
        static int max(int[] a, int n)
        {
            int max = a[0];
            for (int i = 1; i < n; i++)
                if (max < a[i])
                    max = a[i];
            return max;
        }
    }
}
