using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.Utilis.Tasks
{
    public class Task21
    {
        private double _n;
        private double _b;

        public Task21(double n, double b)
        {
            _n = n;
            _b = b;
        }

        

        public double X()
        {
            return Math.Pow(_n, _b) + Math.Pow(_b, 2);
        }

        public double A()
        {
            double x = X();
            return Math.Sin(Math.Pow(x, 2) + Math.Pow(_b, 2));
        }

        public double Y()
        {
            double a = A();
            return (Math.Log10(a)) / (Math.Log10(Math.Pow(_b, 3)));
        }
    }
}
