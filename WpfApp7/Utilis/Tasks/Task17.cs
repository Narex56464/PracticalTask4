using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.Utilis.Tasks
{
    public class Task17
    {
        private double _x;
        private double _t;

        public Task17(double x, double t)
        {
            _x = x;
            _t = t;
        }

        public double B()
        {
            return Math.Pow(Math.Tan(Math.Abs(_x)), 2);
        }

        public double A()
        {
            double b = B();
            return _t * _x + Math.Abs(Math.Sqrt(b));
        }

        public double Y()
        {
            double a = A(), b = B();
            return Math.Pow(Math.Cos(a + Math.Pow(b, 3)), 3);
        }
    }
}
