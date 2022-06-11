using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so nguyen bat ky: ");
            int a = int.Parse(Console.ReadLine());
            if (a >= 0)
                Console.WriteLine("day la so nguyen duong");
            else
                Console.WriteLine("day la so nguyen âm");
            Console.ReadKey();
        }
    }
}
