using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.Utilis.Tasks
{
    public class Task4
    {
        private double _x;
        private double _t;

        public Task4(double x, double t)
        {
            _x = x;
            _t = t;
        }

        public double A()
        {
            return Math.Log10(_x);
        }

        public double B()
        {
            return Math.Sqrt(Math.Pow(_x, 2) + Math.Pow(_t, 2));
        }

        public double Y()
        {
            double a = A(), b = B();
            return Math.Pow(Math.Sqrt(Math.Abs(a - b * _x)), 5);
        }
    }
}
