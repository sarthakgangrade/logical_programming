using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class MonthlyPayment
    {
        public void monthlyPayment()
        {
            Console.WriteLine("enter the loan amount");
            int P = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the number of years");
            int Y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the interest rate");
            int R = Convert.ToInt32(Console.ReadLine());

            int n = 12 * Y;
            double r = R / 1200;
            double monthlyPayment = (P * r) / 1 - Math.Pow((1 + r), -n);

            double totalInterest = monthlyPayment * n - P;

            Console.WriteLine("Monthly Payement = " + monthlyPayment);
            Console.WriteLine("Total Interest = " + totalInterest);




        }

    }
}
