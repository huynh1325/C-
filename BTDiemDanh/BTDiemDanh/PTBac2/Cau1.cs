using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDiemDanh    
{
    internal class Cau1
    {

        public double A162 { get; set; }
        public double B162 { get; set; }
        public double C162 { get; set; }
        public Cau1() { }
        public Cau1(int a162, int b162, int c162)
        {
            A162 = a162;
            B162 = b162;
            C162 = c162;
        }
        public double TinhDelTa()
        {
            return B162 * B162 - 4 * A162 * C162;
        }
        public void GiaiPT()
        {
            double x1, x2;
            if (TinhDelTa() < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem!");
            }
            else if (TinhDelTa() == 0)
            {
                Console.WriteLine("Phuong trinh co nghiem kep");
                x1 = x2 = -B162 / 2 * A162;
            }
            else
            {
                Console.WriteLine("Phuong trinh co 2 nghiem phan biet");
                x1 = (-B162 + Math.Sqrt(TinhDelTa()))/2*A162;
                x2 = (-B162 - Math.Sqrt(TinhDelTa()))/2*A162;
            }
            static void Main(string[] args)
            {
                Cau1 cau1 = new Cau1();

            }
        }
    }
}