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
                Console.WriteLine("Please enter up to 10 floating point numbers (up to 6 places after the decimal) separated by a space.");
                floatString = Console.ReadLine();
                if (string.IsNullOrEmpty(floatString)) Console.WriteLine("You need to input at least one value.");

                if (!string.IsNullOrEmpty(floatString)) {
                    (result, floatsStringList) = FloatMethods.CheckStringOfFloats(floatString);
                    if (result == "floatSizeError")
                    {
                        string floatSizeErrorMessage = floatsStringList.Count > 1 ?
                            "These floats have too many decimals: "
                            : "This float has too many decimals: ";
                        Console.WriteLine(floatSizeErrorMessage);

                        string badFloatStringList = string.Empty;
                        for (int i = 0; i < floatsStringList.Count(); i++)
                        {
                            string ending = i >= 1 || floatsStringList.Count() == 1 ? "." : ", ";
                            badFloatStringList += floatsStringList[i].Trim() + ending;
                        }
                        Console.WriteLine(badFloatStringList);
                    }

                    if (result == "tooManyFloats")
                    {
                        Console.WriteLine("You entered more than 10 values.");
                    }
                }
            } while (string.IsNullOrEmpty(floatString) || result != "good");
            
            List<float> floatsList = FloatMethods.TurnFloatIntoList(floatsStringList);
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
            


            Console.WriteLine();
        }
    }
}
