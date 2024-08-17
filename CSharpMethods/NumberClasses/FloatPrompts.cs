using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMethods.NumberClasses
{
    public class FloatPrompts
    {
        public static void FloatPrompt()
        {
            Console.WriteLine("Please enter up to 10 floating point numbers (up to 6 places after the decimal) separated by a space.");
            string floatString = Console.ReadLine();

            Console.WriteLine();

            float floatSum = FloatMethods.AddFloats(floatString);
            Console.WriteLine($"The sum of your numbers is {floatSum}");
            float floatAvg = FloatMethods.AverageFloats(floatString);
            Console.WriteLine($"The average of your numbers is {floatAvg}");

            Console.WriteLine();
        }
    }
}
