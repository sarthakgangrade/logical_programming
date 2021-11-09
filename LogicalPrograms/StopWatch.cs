using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace LogicalPrograms
{
    class StopWatch
    {
        static void reverse()
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


        public void stopWatch()
        {
            Stopwatch stopwatch = new Stopwatch();       //here created the stopwatch class object

            stopwatch.Start();                            //using start inbuilt method it start the watch

            StopWatch.reverse();

            stopwatch.Stop();      // using stop inbuilt method is stop the watch


            TimeSpan ts = stopwatch.Elapsed; // here created the timespan for calculate the time take for that method

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,                                     // here using string format displaying the time in hrs min sec
            ts.Milliseconds / 10);

            Console.WriteLine("Elapsed time between start and end  " + elapsedTime);


        }

    }
}
