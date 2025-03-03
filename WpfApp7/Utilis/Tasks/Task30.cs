using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.Utilis.Tasks
{
    public class Task30
    {
        private double _t;
        private double _b;

        public Task30(double t, double b)
        {
            _t = t; 
            _b = b;
        }

        public double A()
        {
            return _t + Math.Pow(_b, 3);
        }

        public double X()
        {
            double a = A();
            return Math.Pow(_t, 2) * Math.Sqrt(Math.Abs(a + _b));
        }

        public double Y()
        {
            double a = A(), x = X();
            return Math.Pow(Math.Log(Math.Abs(x + Math.Pow(a, 2))), 5);
        }
    }
}
