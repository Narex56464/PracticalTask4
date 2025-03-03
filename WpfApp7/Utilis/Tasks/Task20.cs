using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.Utilis.Tasks
{
    public class Task20
    {
        private double _x;
        private double _p;

        public Task20(double x, double p)
        {
            _x = x;
            _p = p;
        }

        public double A()
        {
            return Math.Log10(_x);
        }

        public double B()
        {
            return Math.Pow(_x, 4) + Math.Log10(Math.Pow(_p, 3));
        }

        public double Y()
        {
            double a = A(), b = B();
            return Math.Pow(Math.Sin(a * _x), 3) + Math.Sqrt(b) * Math.Cos(Math.Pow(_x, 2));
        }
    }
}
