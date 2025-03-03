using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.Utilis.Tasks
{
    public class Task10
    {
        private double _k;
        private double _m;

        public Task10(double k, double m)
        {
            _k = k;
            _m = m;
        }

        public double X()
        {
            return Math.Exp(_m * _k);
        }

        public double C()
        {
            return Math.Pow(Math.Cos(_m), 2) + Math.Pow(_k, 2);
        }

        public double Y()
        {
            double x = X(), c = C();
            return Math.Pow(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(c, 2)), 3);
        }
    }
}
