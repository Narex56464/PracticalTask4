using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.Utilis.Tasks
{
    public class Task25
    {
        private double _a;
        private double _p;

        public Task25(double a, double p)
        {
            _a = a;
            _p = p;
        }

        public double T()
        {
            return Math.Pow(_p, 3) + Math.Pow(_a, 3);
        }

        public double X()
        {
            return Math.Exp(Math.Sqrt(_p + _a));
        }

        public double Y()
        {
            double x = X(), t = T();
            return (Math.Pow(x, 3)) / (Math.Pow(t, 2));
        }
    }
}
