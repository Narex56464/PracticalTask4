using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.Utilis.Tasks
{
    public class Task26
    {
        private double _b;
        private double _t;

        public Task26(double b, double t)
        {
            _b = b;
            _t = t;
        }

        public double A()
        {
            return Math.Sqrt(_b + Math.Pow(_t, 2));
        }

        public double X()
        {
            double a = A();
            return Math.Pow(Math.Cos(_b), 2) + Math.Pow(Math.Sin(a), 2);
        }

        public double Y()
        {
            double x = X();
            return Math.Pow(x, 2) + Math.Pow(Math.Sqrt(Math.Abs(x)), 3);
        }
    }
}
