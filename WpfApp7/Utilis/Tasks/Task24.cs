using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.Utilis.Tasks
{
    public class Task24
    {
        private double _t;
        private double _b;

        public Task24(double t, double b)
        {
            _t = t;
            _b = b;
        }

        public double A()
        {
            return Math.Pow(_t, 2) * _b;
        }

        public double X()
        {
            double a = A();
            return Math.Pow(a, 3) + Math.Sqrt(_t + _b);
        }

        public double Y()
        {
            double x = X();
            return Math.Cos(Math.Pow(x, 5)) - _b * Math.Pow(Math.Sin(x), 2);
        }
    }
}
