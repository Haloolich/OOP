using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_3_v16
{
    public class Complex : Norm
    {
        private double real, imag;

        public Complex(double real, double imag)
        {
            this.real = real;
            this.imag = imag;
        }

        public override double CalculateNorm()
        {
            return real * real + imag * imag;
        }

        public override double CalculateModulus()
        {
            return Math.Sqrt(real * real + imag * imag);
        }
    }

}
