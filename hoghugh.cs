using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoghugh
{
    class hoghugh
    {
        private double khales;
        private double bime;
        private double tax;

        public double Khales
        {
            get { return khales; }
            set { khales = value; }
        }
        public double Bime
        {
            get { return bime; }
            set { bime = value; }
        }
        public double Tax
        {
            get { return tax; }
            set { tax = value; }
        }

        public hoghugh() { }
        public hoghugh(double Khales,double Bime,double Tax)
        {
            khales = Khales;
            bime = Bime;
            tax = Tax;
        }

        public double calc()
        {
            double res = (khales - bime) / tax;
            return res;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            double khales = Convert.ToDouble(Console.ReadLine());
            double bime = Convert.ToDouble(Console.ReadLine());
            double tax = Convert.ToDouble(Console.ReadLine());
            hoghugh H = new hoghugh(khales, bime, tax);
            double result = H.calc();
            Console.WriteLine(result);

        }
    }
}
