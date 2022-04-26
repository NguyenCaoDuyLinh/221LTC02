using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt26_4
{
    public class Ptbac2
    {
        private int a134;
        private int b134;
        private int c134;
        public Ptbac2()
        { }
        public Ptbac2(int a134, int b134, int c134)
        {
            this.A134 = a134;
            this.B134 = b134;
            this.C134 = c134;
        }

        public int A134 { get => a134; set => a134 = value; }

        public int B134 { get => b134; set => b134 = value; }
        public int C134 { get => c134; set => c134 = value; }

        public int delta()
        {
            return b134 * b134 - 4 * a134 * c134;
        }
        public void nghiem()
        {

            if (delta() < 0)
                Console.WriteLine("Phuong trinh vo nghiem");
            else
                if (delta() == 0)
                Console.WriteLine("Phuong trinh co mot nghiem {0}", -b134 / 2 * a134);
            else
                Console.WriteLine("Phuong trinh co 2 nghiem: x1 = {0}, x2 = {1}", (-b134 + Math.Sqrt(delta()) / 2 * a134), (-b134 - Math.Sqrt(delta()) / 2 * a134));
        }
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
