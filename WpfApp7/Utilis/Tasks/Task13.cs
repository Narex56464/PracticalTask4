using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.Utilis.Tasks
{
    public class Task13
    {
        private double _x;
        private double _a;

        public Task13(double x, double a)
        {
            _x = x;
            _a = a;
        }

        public double W()
        {
            return Math.Pow(_x, 2) * Math.Sqrt(Math.Abs(_a + _x));
        }

        public double Z()
        {
            double w = W();
            return Math.Pow(Math.Cos(_a), 2) + Math.Pow(w, 2);
        }

        public double Y()
        {
            double z = Z(), w = W();
            return _a * Math.Pow(z, 7) + Math.Pow(Math.Sin(w), 2);
        }
    }
}
