using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class TemperatureConversion
    {
        public double getCelsius(double cs)
        {
            

            double fahrenheit;
            fahrenheit = (cs * 9 / 5) + 32;
            Console.WriteLine("the temperature in celsius into fahrenheit is: "+fahrenheit);
            return 0;

        }
        public double getfahrenheit(double f)
        {
            

            double celsius;
            celsius = ((f - 32) * 5) / 9;
            Console.WriteLine("the temperature in fahrenheit into celsius is: "+celsius);
            return 0;

        }

        public void temperature()
        {
            Console.WriteLine("enter temperatur in Celsius:");
            double celsius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter temperatur in fahrenheit:");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            getCelsius(celsius);
            getfahrenheit(fahrenheit);
        }
    }
}
