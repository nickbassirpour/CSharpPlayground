using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMethods
{
    public static class StringMethods
    {
        public static string MakeFullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }

        public static string ReverseName(string name)
        {
            List<char> output = new List<char>();
            
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("no name provided.");
            }


            for (int i = name.Length - 1; i >= 0; i--)
            {
                output.Add(name[i]);
            }

            return string.Join("", output);
        }

        public static string CutString(string name, int indexToCut)
        {
            return name.Substring(indexToCut);
        }
    }
}
