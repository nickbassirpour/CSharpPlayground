using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMethods.NumberClasses
{
    public class FloatMethods
    {
        public static (string, List<string>) CheckStringOfFloats(string floatString)
        {
            var floatsStringEnum = (from fs 
                                    in floatString.Split()
                                    select fs);

            List<string> floatsStringList = floatsStringEnum.ToList();

            List<string> floatSizeErrors = new List<string>();

            foreach (string floatStr in floatsStringList)
            {
                if (floatStr.Contains(".") && floatStr.ToString().Split(".")[1].Length > 6)
                {
                    floatSizeErrors.Add(floatStr);
                }
            }
            if (floatSizeErrors.Count > 0) return ("floatSizeError", floatSizeErrors);
            
            if (floatsStringList.Count > 10)
            {
                return ("tooManyFloats", floatsStringList);
            }

            return ("good", floatsStringList);
        }
        public static List<float> TurnFloatIntoList(List<string> floatsStringList)
        {
            return floatsStringList.Select(float.Parse).ToList();
        }
        public static float AddFloats(List<float> floatsList)
        {
            return floatsList.Sum();
        }

        public static float AverageFloats(List<float> floatsList)
        {
            return floatsList.Average();
        }
    }
}
