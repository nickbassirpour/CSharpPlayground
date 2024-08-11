using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
