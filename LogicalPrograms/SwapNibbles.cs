using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class SwapNibbles
    {

        public int swap(int x)
        {
            return ((x & 0x0F) << 4 |
                    (x & 0xF0) >> 4);
        }

        public void swapNibbles()
        {
            Console.WriteLine("enter the number to convert in Binary ");
            int num = Convert.ToInt32(Console.ReadLine());
            /*string res = " ";
            while (num > 1)
            {
                int rem = num % 2;
                res = Convert.ToString(rem) + res;
                num = num / 2;


            }
            res = Convert.ToString(num) + res;
            Console.WriteLine("the binary representation is :" + res);*/
            
            Console.WriteLine("after swap nibbles the new number is:"+ swap(num));
            

        }
    }
}
