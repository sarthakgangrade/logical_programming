using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class ReverseNumber
    {

        public void reverseNumber()
        {
            Console.WriteLine("enter the number to reverse to that number");
            int Num = Convert.ToInt32(Console.ReadLine());
            int rem = 0;
            int rev = 0;
            Console.WriteLine("the Main Number is :{0}", Num);


            while (Num != 0)   //here checking the number is not equal 0
            {
                rem = Num % 10;          //here divide the number by 10 to get Remainder
                rev = rev * 10 + rem;         //here adding the remainder in rev *10
                Num = Num / 10;              // after that number will divide by the 10 get the Quotient 

            }
            Console.WriteLine("the revrse Number is :{0}", rev);


        }
    }
}
