using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class BinaryConversion
    {
        /// <summary>
        ///  conversion of decimale  To the binary.
        /// </summary>
        public void toBinary()
        {
            Console.WriteLine("enter the number you want to convert in Binary:");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[10];
            int i;
            for ( i = 0; num > 0; i++)
            {
                arr[i] = num % 2;
                num /= 2;

            }
            
            for ( i = i-1; i>=0; i--)
            {

                Console.WriteLine(arr[i]);
            }

            //using another method
            /*string res=" ";
            while (num > 1)
            {
                int rem = num % 2;
                res = Convert.ToString(rem) + res;
                num = num / 2;


            }
            res = Convert.ToString(num) + res;
            Console.WriteLine("the binary representation is :" + res);*/
        }

    }
}
