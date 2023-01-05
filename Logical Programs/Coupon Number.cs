using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Coupon_Number
    {
        public void CouponNumber()
        {
            Console.WriteLine("Enter how many coupon number needed");
            int NumCoupon=Convert.ToInt32(Console.ReadLine());
            int Temp;
            Console.WriteLine("Coupon Numbers are ");
            for(int i=1;i<=NumCoupon;i++)
            {
                int Coupon=0;
                Random random=new Random();
                for(int j=1;j<=6;j++)
                {
                    Temp = random.Next(0, 9);
                    Coupon = Coupon * 10 + Temp;
                }
                Console.WriteLine(Coupon);
            }
        }
    }
}
