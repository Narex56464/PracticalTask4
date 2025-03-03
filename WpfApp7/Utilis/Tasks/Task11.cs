using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.Utilis.Tasks
{
    public class Task11
    {
        private double _x;
        private double _b;

        public Task11(double x, double b)
        {
            _x = x;
            _b = b;
        }

        public double C()
        {
            return Math.Log10(Math.Abs(_b));
        }

        public double A()
        {
            return Math.Pow(_b + _x, 3);
        }

        public double Y()
        {
            double c = C(), a = A();
            return Math.Pow(c, 2) + Math.Sqrt(Math.Abs(a));
        }
    }
}
