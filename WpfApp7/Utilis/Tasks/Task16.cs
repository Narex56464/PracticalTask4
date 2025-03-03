using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.Utilis.Tasks
{
    public class Task16
    {
        private double _x;
        private double _c;

        public Task16(double x, double c)
        {
            _x = x;
            _c = c;
        }

        public double B()
        {
            return _x + Math.Pow(_c, 2);
        }

        public double A()
        {
            double b = B();
            return Math.Pow(Math.Sqrt(Math.Abs(b + _c)), 3);
        }

        public double Y()
        {
            double b = B(), a = A();
            return Math.Pow(Math.Cos(b), 2) + b * Math.Pow(Math.Cos(Math.Pow(a, 2)), 4);
        }
    }
}
