using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.Utilis.Tasks
{
    public class Task29
    {
        private double _a;
        private double _b;

        public Task29(double a, double b)
        {
            _a = a;
            _b = b;
        }

        public double X()
        {
            return Math.Exp(2 * _a) + Math.Sqrt(_b);
        }

        public double P()
        {
            double x = X();
            return x * (_a + Math.Pow(_b, 3));
        }

        public double Y()
        {
            double x = X(), p = P();
            return Math.Pow(Math.Log10(Math.Abs(p)), 3) + x;
        }
    }
}
