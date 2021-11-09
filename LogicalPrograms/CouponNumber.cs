using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class CouponNumber
    {

        public void couponNumber()
        {
            int[] couponNumber = { 12, 22, 18, 28, 14 };
            Random random = new Random();
            int r = 0;


            for (int i = 0; i <= couponNumber.Length; i++)
            {
                int newNum = random.Next(10, 30);
                if (couponNumber[i] != newNum)
                {
                    r++;

                }



            }
            Console.WriteLine("the total random number to genrate the distinct value is:" + r);

        }
    }
}
