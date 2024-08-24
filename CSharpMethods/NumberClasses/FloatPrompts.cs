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
            string floatString = string.Empty;
            string result = string.Empty;
            List<string> floatsStringList = new List<string>();

            do
            {
               (floatString, result, floatsStringList) = FloatMethods.CheckFloatStringList();
            } while (string.IsNullOrEmpty(floatString) || result != "good");
            
            List<float> floatsList = FloatMethods.TurnIntoFloatList(floatsStringList);
            Console.WriteLine();

            float floatSum = FloatMethods.AddFloats(floatsList);
            Console.WriteLine($"The sum of your numbers is {floatSum}");
            float floatAvg = FloatMethods.AverageFloats(floatsList);
            Console.WriteLine($"The average of your numbers is {floatAvg}");
            float? floatMedian = FloatMethods.MedianFloat(floatsList);
            if (floatMedian != null)
            {
                Console.WriteLine($"The median of your numbers is {floatMedian}");
            }
            else
            {
                Console.WriteLine("There is no midpoint since the count is even");
            }
            Console.WriteLine($"The biggest float is {floatsList.Max()}");
            Console.WriteLine($"The smallest float is {floatsList.Min()}");

            // I need a drink
            Console.WriteLine();
        }
    }
}
