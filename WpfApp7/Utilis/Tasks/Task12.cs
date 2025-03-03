using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.Utilis.Tasks
{
    public class Task12
    {
        private double _q;
        private double _b;

        public Task12(double q, double b)
        {
            _q = q;
            _b = b;
        }

        public double T()
        {
            return Math.Pow(_b, 3) + Math.Exp(Math.Sqrt(_q));
        }

        public double X()
        {
            double t = T();
            return Math.Pow(t, 3) + Math.Pow(_b, 2);
        }

        public double Y()
        {
            double x = X();
            return Math.Pow(Math.Atan(Math.Abs(x)), 2);
        }
    }
}
