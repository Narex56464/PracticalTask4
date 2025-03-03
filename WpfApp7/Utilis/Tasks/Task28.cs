using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.Utilis.Tasks
{
    public class Task28
    {
        private double _b;
        private double _k;

        public Task28(double b, double k)
        {
            _b = b;
            _k = k;
        }

        public double T()
        {
            return Math.Pow(_k, 2) + Math.Sqrt(_b);
        }

        public double A()
        {
            double t = T();
            return _b + Math.Pow(t, 2) * Math.Exp(t);
        }

        public double Y()
        {
            double a = A();
            return Math.Pow(Math.Cos(Math.Pow(a, 3) + _b), 4);
        }
    }
}
