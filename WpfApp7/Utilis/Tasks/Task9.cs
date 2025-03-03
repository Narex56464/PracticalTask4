using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.Utilis.Tasks
{
    public class Task9
    {
        private double _x;
        private double _b;

        public Task9(double x, double b)
        {
            _x = x;
            _b = b;
        }

        public double A()
        {
            return Math.Pow(_b, 3) + Math.Log10(Math.Abs(_b));
        }

        public double C()
        {
            double a = A();
            return Math.Pow(a, 2) + Math.Sqrt(_b);
        }

        public double Y()
        {
            double c = C();
            return Math.Exp(_x) + Math.Pow(5.8, c);
        }
    }
}
