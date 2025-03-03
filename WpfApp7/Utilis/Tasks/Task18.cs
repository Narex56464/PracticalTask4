using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.Utilis.Tasks
{
    public class Task18
    {
        private double _x;
        private double _b;

        public Task18(double x, double b)
        {
            _x = x;
            _b = b;
        }

        public double A()
        {
            return Math.Sqrt(Math.Abs(_x)) + Math.Exp(Math.Sqrt(_b));
        }

        public double C()
        {
            double a = A();
            return Math.Log10(a) + Math.Pow(_b, 2);
        }

        public double Y()
        {
            double a = A(), c = C();
            return (Math.Pow(a, 3)) / (Math.Cos(c));
        }
    }
}
