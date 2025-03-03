using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.Utilis.Tasks
{
    public class Task14
    {
        private double _b;
        private double _k;

        public Task14(double b, double k)
        {
            _b = b;
            _k = k;
        }

        public double T()
        {
            return Math.Pow(_b, 2) + Math.Pow(_k, 3);
        }

        public double A()
        {
            double t = T();
            return Math.Sqrt(_b + t);
        }

        public double Y()
        {
            double a = A();
            return Math.Pow(Math.Sin(Math.Pow(a, 2) + Math.Pow(_b, 2)), 4);
        }
    }
}
