using System;
using System.Collections.Generic;
using System.Text;

namespace CuponWithoutOCP
{
    class CouponWithNominal : Coupon
    {
        public double discNominal;

        public CouponWithNominal(double discNominal)
        {
            this.discNominal = discNominal;
        }

        public override double calculate(double originPrice)
        {
            return originPrice - discNominal;
        }
    }
}
