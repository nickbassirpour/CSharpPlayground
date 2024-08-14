using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMethods.NumberClasses
{
    public class IntMethods
    {
        public static int AddInts(List<int> numbers)
        {
            return numbers.Sum(x => x);
        }

        public static int SubtractInts(List<int> numbers)
        {
            return Math.Abs(numbers[0] - numbers[1]);

        }

        public static int MultiplyInts(List<int> numbers)
        {
            return numbers[0] * numbers[1];
        }
    }
}
