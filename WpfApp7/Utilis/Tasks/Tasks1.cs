using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.Utilis.Tasks
{
    public class Tasks1
    {
        private double _x;
        private double _b;

        public Tasks1(double x, double b)
        {
            _x = x;
            _b = b;
        }

        public double A()
        {
            return Math.Log10(_x);
        }

        public double C()
        {
            double a = A();
            return Math.Pow(a, 2) + Math.Sqrt(_b * _x);
        }

        public double Y()
        {
            double c = C();
            return Math.Exp(2 * _x) + Math.Pow(9.7, c);
        }
    }
}
