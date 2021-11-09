using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class FibonacciSeries
    {

        public void fibonacciSeries()
        {

            Console.WriteLine("enter the number you want to fibonacci series");
            int num = Convert.ToInt32(Console.ReadLine());
            int first = 0, second = 1;
            int th = 0;
            Console.WriteLine("the Fibonacci series is:");
            Console.WriteLine(first);
            Console.WriteLine(second);
            for (int i = 0; i < num; i++)
            {

                th = first + second;
                Console.WriteLine(th);

                first = second;
                second = th;

            }
        }
    }
}
