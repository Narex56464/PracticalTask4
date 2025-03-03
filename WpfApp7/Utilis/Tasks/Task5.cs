using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.Utilis.Tasks
{
    public class Task5
    {
        private double _t;
        private double _p;

        public Task5(double t, double p)
        {
            _t = t;
            _p = p;
        }

        public double X()
        {
            double k = K();
            return _p * Math.Pow(_t, 2) + Math.Sqrt(k);
        }

        public double K()
        {
            return Math.Sqrt(_p * _t);
        }

        public double Y()
        {
            double k = K(), x = X();
            return Math.Pow(Math.Tan(Math.Pow(x, 2)), 3) + k * _t;
        }
    }
}
