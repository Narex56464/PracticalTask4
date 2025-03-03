using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.Utilis.Tasks
{
    public class Task27
    {
        private double _t;
        private double _a;

        public Task27(double t, double a)
        {
            _t = t;
            _a = a;
        }

        public double C()
        {
            return Math.Pow(_t, 2) + Math.Sqrt(_a);
        }

        public double X()
        {
            double c = C();
            return Math.Log(Math.Abs(c * _t)) + Math.Pow(_a, 2);
        }

        public double Y()
        {
            double x = X();
            return Math.Tan(4 * x) + Math.Sin(Math.Pow(x, 2));
        }
    }
}
