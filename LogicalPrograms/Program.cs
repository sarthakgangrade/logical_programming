using System;


namespace LogicalPrograms
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string yes = "y";
            string y;

            do
            {
                Console.WriteLine("1.Fibonacci Series\n2.Perfect Number\n3.Prime Number\n4.Reverse a Number\n5.Coupon Number\n6.StopWatch\n7.Notes Vending Machine\n8.DayOfWeek\n9.TemperatureConversion\n10.Monthly Payment\n11.Square Root\n12.BinaryConversion\n13.BinarySwapNibbles");
                Console.WriteLine("enter the choice");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        FibonacciSeries fs = new FibonacciSeries();
                        fs.fibonacciSeries();
                        break;
                    case 2:
                        PerfectNumber perfect = new PerfectNumber();
                        perfect.perfectNumber();
                        break;
                    case 3:
                        PrimeNumber prime = new PrimeNumber();
                        prime.primeNumber();
                        break;
                    case 4:
                        ReverseNumber reverse = new ReverseNumber();
                        reverse.reverseNumber();
                        break;
                    case 5:
                        CouponNumber coupon = new CouponNumber();
                        coupon.couponNumber();
                        break;
                    case 6:
                        StopWatch stop = new StopWatch();
                        stop.stopWatch();
                        break;
                    case 7:
                        Notes notes = new Notes();
                        notes.notesCounter();
                        break;
                    case 8:
                        DayOfWeek day = new DayOfWeek();
                        day.dayOfWeek();
                        break;
                    case 9:
                        TemperatureConversion temperature = new TemperatureConversion();
                        temperature.temperature();
                        break;
                    case 10:
                        MonthlyPayment payment = new MonthlyPayment();
                        payment.monthlyPayment();
                        break;
                    case 11:
                        SquareRoot square = new SquareRoot();
                        square.squareRoot();
                        break;
                    case 12:
                        BinaryConversion binary = new BinaryConversion();
                        binary.toBinary();
                        break;
                    case 13:
                        SwapNibbles swap = new SwapNibbles();
                        swap.swapNibbles();
                        break;

                }
                Console.WriteLine("Do You Want Continue...(y/n)");
                y = Console.ReadLine();

            } while (yes == y);
            Console.ReadLine();
        }

    }
}
