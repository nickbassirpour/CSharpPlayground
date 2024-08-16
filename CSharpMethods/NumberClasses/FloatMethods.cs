using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMethods.NumberClasses
{
    public class FloatMethods
    {
        public static float AddFloats(string floatString)
        {
            var floatsStringEnum = (from fs in floatString.Split()
                              select fs);
            List<string> floatsStringList = floatsStringEnum.ToList();
            List<float> floatsList = floatsStringList.Select(float.Parse).ToList();

            float floatSum = floatsList.Sum();

            return floatSum;
        }
    }
}
