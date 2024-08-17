using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMethods.NumberClasses
{
    public class FloatMethods
    {

        public static List<float> TurnFloatIntoList(string floatString)
        {
            var floatsStringEnum = (from fs in floatString.Split()
                                    select fs);
            List<string> floatsStringList = floatsStringEnum.ToList();
            List<float> floatsList = floatsStringList.Select(float.Parse).ToList();

            return floatsList;
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
