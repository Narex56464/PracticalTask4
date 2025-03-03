using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.Utilis.Tasks
{
    public class Task15
    {
        private double _a;
        private double _p;

        public Task15(double a, double p)
        {
            _a = a;
            _p = p;
        }

        public double B()
        {
            return Math.Abs(_a) + Math.Sqrt(_a + Math.Pow(_p, 2));
        }

        public double X()
        {
            double b = B();
            return Math.Exp(b);
        }

        public double Y()
        {
            double x = X();
            return Math.Pow(Math.Cos(x), 3) + Math.Abs(_a);
        }
    }
}
