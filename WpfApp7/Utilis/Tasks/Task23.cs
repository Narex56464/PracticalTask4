using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.Utilis.Tasks
{
    public class Task23
    {
        private double _x;
        private double _b;

        public Task23(double x, double b)
        {
            _x = x;
            _b = b;
        }

        public double T()
        {
            return _x * Math.Pow(_b, 2) + Math.Sqrt(_x);
        }

        public double A()
        {
            double t = T();
            return Math.Log10(Math.Abs(t * _x + Math.Pow(_b, 2)));
        }

        public double Y()
        {
            double t = T(), a = A();
            return Math.Log(a + _b) + (Math.Pow(a, 2)) / (a + t);
        }
    }
}
