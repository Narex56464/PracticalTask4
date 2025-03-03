using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.Utilis.Tasks
{
    public class Task7
    {
        private double _x;
        private double _k;

        public Task7(double x, double k)
        {
            _x = x;
            _k = k;
        }

        public double C()
        {
            return Math.Sqrt(Math.Abs(_x));
        }

        public double A()
        {
            double c = C();
            return Math.Pow(c, 4) + Math.Pow(_k, 3);
        }

        public double Y()
        {
            double a = A();
            return Math.Pow(Math.Log10(a), 3) + Math.Pow(Math.Cos(_x), 5);
        }
    }
}
