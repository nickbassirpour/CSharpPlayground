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
            Console.WriteLine("Please enter up to 10 floating point numbers (up to 6 places after the decimal).");
            string floatString = Console.ReadLine();
        }
    }
}
