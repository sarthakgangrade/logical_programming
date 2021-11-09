using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class SquareRoot
    {
        /// <summary>
        /// Squares the root.
        /// finding the square root using newtons law
        /// </summary>
        public void squareRoot()
        {  
            
            Console.WriteLine("enter the Number to find square root"); 
            double c = Convert.ToDouble(Console.ReadLine());
            double t = c;      // initialize given number  to t;
            double nx;
            const double eps = 1e-15;     
            for (; ; )                                       
            {
                //calculating square root of given number using Newtons law
                 nx = 0.5 * (t + (c / t));
                if (Math.Abs(t - nx) < eps * t)
                {
                    break;
                }
                t = nx;

            }

            Console.WriteLine("the Square Root is :" + nx);

        }
    }
}
