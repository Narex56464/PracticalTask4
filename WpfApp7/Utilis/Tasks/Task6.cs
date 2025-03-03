using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.Utilis.Tasks
{
    public class Task6
    {
        private double _x;
        private double _m;

        public Task6(double x, double m)
        {
            _x = x;
            _m = m;
        }

        public double A()
        {
            return Math.Sqrt(Math.Abs(_x));
        }

        public double B()
        {
            return Math.Pow(_x, 4) + Math.Pow(_m, 2);
        }

        public double Y()
        {
            double a = A(), b = B();
            return Math.Pow(Math.Sin(a + Math.Pow(Math.Tan(b), 3)), 2);
        }
    }
}
