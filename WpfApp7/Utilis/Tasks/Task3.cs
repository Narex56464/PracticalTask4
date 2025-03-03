using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.Utilis.Tasks
{
    public class Task3
    {
        private double _x;
        private double _p;

        public Task3(double x, double p)
        {
            _x = x;
            _p = p;
        }

        public double A()
        {
            return Math.Exp(Math.Sqrt(Math.Abs(_x)));
        }

        public double B()
        {
            return Math.Sin(Math.Pow(_p, 2)) + Math.Pow(_x, 3);
        }

        public double Y()
        {
            double a = A(), b = B();
            return (Math.Pow(a, 3)) / (Math.Pow(b, 2));
        }
    }
}
