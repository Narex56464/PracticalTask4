using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.Utilis.Tasks
{
    public class Task22
    {
        private double _m;
        private double _p;

        public Task22(double m, double p)
        {
            _m = m;
            _p = p;
        }

        public double T()
        {
            return Math.Sin(Math.Pow(_m, 3));
        }

        public double X()
        {
            double t = T();
            return Math.Pow(_p, 2) + t;
        }

        public double Y()
        {
            double x = X(), t = T();
            return Math.Pow(Math.Log10(Math.Abs(x + t)), 4);
        }
    }
}
