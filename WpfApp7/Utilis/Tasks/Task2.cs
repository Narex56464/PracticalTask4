using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.Utilis.Tasks
{
    public class Task2
    {
        private double _x;

        public Task2(double x)
        {
            _x = x;
        }

        public double A()
        {
            return Math.Log10(_x);
        }

        public double B()
        {
            double a = A();

            return Math.Exp(2 * _x) + a * _x;
        }

        public double Y()
        {
            double a = A(), b = B();
            return _x * Math.Pow(a, 3) + Math.Pow(b, 2);
        }
    }
}
