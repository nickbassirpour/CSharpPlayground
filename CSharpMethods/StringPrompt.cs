using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMethods
{
    public static class StringPrompt
    {
        public static void StringPrompts()
        {

            Console.WriteLine("Please enter your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name: ");
            string lastName = Console.ReadLine();

            string fullName = StringMethods.MakeFullName(firstName, lastName);
            Console.WriteLine($"Your full name is {fullName}");

            string reverseFullName = StringMethods.ReverseName(fullName);
            Console.WriteLine($"Your full name reversed is {reverseFullName}");

            bool success = false;
            int indexToCut;

            do
            {
                Console.WriteLine($"Type a number greater than 0 and less than {fullName.Length}: ");
                string stringIndex = Console.ReadLine();
                success = int.TryParse(stringIndex, out indexToCut);
                if (!success)
                {
                    Console.WriteLine("That was not a correct input.");
                }
                if (success && indexToCut < 1 || indexToCut >= fullName.Length)
                {
                    Console.WriteLine("That number is out of range.");
                }
            } while (!success && indexToCut < 1 || indexToCut >= fullName.Length);

            string cutName = StringMethods.CutString(fullName, indexToCut);
            Console.WriteLine($"Your cut name is: {cutName}");

        }
    }
}
