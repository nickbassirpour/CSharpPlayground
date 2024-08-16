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

            float floatSum = FloatMethods.AddFloats(floatString);
            Console.WriteLine($"The sum of your numbers is {floatSum}");

        }
    }
}
