using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.Utilis.Tasks
{
    public class Task8
    {
        private double _b;
        private double _c;

        public Task8(double b, double c)
        {
            _b = b;
            _c = c;
        }

        public double A()
        {
            return Math.Sin(_b);
        }

        public double X()
        {
            double a = A();
            return a + Math.Pow(_b + _c, 3);
        } 

        public double Y()
        {
            double x = X();
            return 7 * Math.Exp(Math.Sqrt(Math.Abs(x))) + Math.Pow(Math.Cos(x), 4);
        }
    }
}
