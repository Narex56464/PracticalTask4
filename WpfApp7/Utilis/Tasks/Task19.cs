using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.Utilis.Tasks
{
    public class Task19
    {
        private double _x;
        private double _a;

        public Task19(double x, double a)
        {
            _x = x;
            _a = a;
        }
        
        public double P()
        {
            return Math.Pow(_x, 2) - Math.Sqrt(Math.Abs(_x));
        }

        public double T()
        {
            return Math.Pow(_x, 2) + Math.Pow(_a, 2);
        }

        public double Y()
        {
            double p = P(), t = T();
            return _x * Math.Pow(p, 2) + Math.Pow(t, 5);
        }
    }
}
