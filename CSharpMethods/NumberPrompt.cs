using CSharpMethods.NumberClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMethods
{
    public class NumberPrompt
    {
        public static void NumberPrompts()
        {
            Console.WriteLine("Do you want to learn about ints, floats, doubles, or decimals?");
            string chosenNumber = Console.ReadLine();
            switch (chosenNumber)
            {
                case "ints":
                    IntPrompts.IntPrompt();
                    break;
                case "floats":
                    FloatPrompts.FloatPrompt(); 
                    break;
                default:
                    break;
            }
        }
    }
}
