using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMethods.NumberClasses
{
    public class IntPrompts
    {
        public static void IntPrompt()
        {
            bool twoNumbers = false;
            List<string> numbersSplit = new List<string>();
            bool goodNumber = false;
            List<int> numbersList = new List<int>();
            List<int> badNumbersList = new List<int>();

            do
            {
                badNumbersList.Clear();
                numbersList.Clear();
                Console.WriteLine("Please enter two numbers separated by a space.");
                string numbers = Console.ReadLine();
                numbersSplit = numbers.Split(" ").ToList();
                if (numbersSplit.Count > 2 || numbersSplit.Count == 1)
                {
                    Console.WriteLine("Please enter exactly two numbers.");
                } 
                else
                {
                    twoNumbers = true;
                    foreach (string number in numbersSplit)
                    {
                        goodNumber = int.TryParse(number, out int value);
                        if (!goodNumber)
                        {
                            badNumbersList.Add(value);
                        } 
                        else
                        {
                            numbersList.Add(value);
                        }
                    }
                    if (badNumbersList.Count > 0)
                    {
                        Console.WriteLine("You did not enter accurate numbers.");
                    }
                }
            } while (twoNumbers == false || badNumbersList.Count > 0);

            Console.WriteLine($"The sum of your numbers is: {IntMethods.AddInts(numbersList)}");
        }
    }
}
