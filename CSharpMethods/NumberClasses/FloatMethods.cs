using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMethods.NumberClasses
{
    public class FloatMethods
    {
        public static (string, string, List<string>) CheckFloatStringList()
        {
            string floatString = string.Empty;
            string result = string.Empty;
            List<string> floatsStringList = new List<string>();

            Console.WriteLine("Please enter up to 10 floating point numbers (up to 6 places after the decimal) separated by a space.");
            floatString = Console.ReadLine();
            if (string.IsNullOrEmpty(floatString)) Console.WriteLine("You need to input at least one value.");

            if (!string.IsNullOrEmpty(floatString))
            {
                (result, floatsStringList) = FloatMethods.CheckEachString(floatString);
                if (result == "notFloatError")
                {
                    string notFloatErrorMessage = floatsStringList.Count > 1 ?
                        "These are not valid floats: "
                        : "This is not a valid float: ";
                    Console.WriteLine(notFloatErrorMessage);

                    string notFloatErrorStringList = string.Empty;
                    for (int i = 0; i < floatsStringList.Count; i++)
                    {
                        string ending = i >= 1 || floatsStringList.Count() == 1 ? "." : ",";
                        notFloatErrorStringList += floatsStringList[i].Trim() + ending;
                    }
                    Console.WriteLine(notFloatErrorStringList);
                }
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
                    Console.WriteLine("You entered more than 10 values!");
                }
            }
            return (floatString, result, floatsStringList);
        }
        public static (string, List<string>) CheckEachString(string floatString)
        {
            var floatsStringEnum = (from fs 
                                    in floatString.Split()
                                    select fs);

            List<string> floatsStringList = floatsStringEnum.ToList();
            List<string> notFloatErrorList = new List<string>();
            List<string> floatSizeErrors = new List<string>();

            foreach (string floatStr in floatsStringList)
            {
                if (!float.TryParse(floatStr, out float result))
                {
                    notFloatErrorList.Add(floatStr);
                }
                if (notFloatErrorList.Count > 0) return ("notFloatError", notFloatErrorList);
            }

            foreach (string floatStr in floatsStringList)
            {
                if (floatStr.Contains(".") && floatStr.ToString().Split(".")[1].Length > 6)
                {
                    floatSizeErrors.Add(floatStr);
                }
                if (floatSizeErrors.Count > 0) return ("floatSizeError", floatSizeErrors);
            }

            if (floatsStringList.Count > 10)
            {
                return ("tooManyFloats", floatsStringList);
            }
            
            return ("good", floatsStringList);
        }
        public static List<float> TurnIntoFloatList(List<string> floatsStringList)
        {
            return floatsStringList.Select(float.Parse).ToList();
        }
        public static float AddFloats(List<float> floatsList)
        {
            return floatsList.Sum();
        }

        public static float AverageFloats(List<float> floatsList)
        {
            // Am I taking OOP too far? 
            return floatsList.Average();
        }

        public static float? MedianFloat(List<float> floatsList)
        {
        // This method makes more sense to abstract because it has more 
        // than one line of logic. The others can all be abstracted
        int count = floatsList.Count();
            if (count % 2 == 0) return null;
            int midpoint = count / 2;
            return floatsList.OrderBy(n => n).ElementAt(midpoint);
        }
    }
}
