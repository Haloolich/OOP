using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_3_v16
{
    public class Vector3D : Norm
    {
        private double x, y, z;

        public Vector3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override double CalculateNorm()
        {
            return Math.Max(Math.Max(Math.Abs(x), Math.Abs(y)), Math.Abs(z));
        }

        public override double CalculateModulus()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }
    }

}
