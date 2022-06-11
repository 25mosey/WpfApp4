using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    internal class Gipotenyza
    {
        public double A { get; set; }
        public double B { get; set; }

        public Gipotenyza(double a, double b)
        {
            A = a;
            B = b;
        }
        public double Dlina()
        {
            return Math.Sqrt(A * A + B * B);
        }
    }
}
