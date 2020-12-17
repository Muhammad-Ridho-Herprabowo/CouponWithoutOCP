using System;
using System.Collections.Generic;
using System.Text;

namespace CuponWithoutOCP
{


    public abstract class Coupon
    {
        public abstract double calculate(double originPrice);
    }
}
