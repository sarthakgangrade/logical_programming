using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class DayOfWeek
    {
        public int getDay(int day)
        {
            switch (day)
            {

                case 0:
                     Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
            }
            return 0;
         }

        public void dayOfWeek()
        {
            Console.WriteLine("enter the Date:");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the Month:");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the Year:");
            int y = Convert.ToInt32(Console.ReadLine());

            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;


            Console.WriteLine("y0={0} x={1} m0={2} d0={3}", y0, x, m0, d0);
            Console.WriteLine("the day of week is");
            getDay(d0);
            

            
            

        }


    }
}
