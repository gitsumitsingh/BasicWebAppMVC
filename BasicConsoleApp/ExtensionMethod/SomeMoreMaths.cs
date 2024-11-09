using BasicClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleApp.ExtensionMethod1
{
    public static class SomeMoreMaths
    {
        /// <summary>
        /// This is an Subtract Extension method to minus two numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>number</returns>
        public static int Subtract(this MathThirdParty obj, int num1, int num2)
        {
            return num1 - num2;
        }

        /// <summary>
        /// This is an Divide Extension method to divide two numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>number</returns>
        public static int Divide(this MathThirdParty obj, int num1, int num2)
        {
            return num1 / num2;
        }

        // Method 4
        public static void M4(this MathThirdParty obj)
        {
            Console.WriteLine("Method Name: M4");
        }

        // Method 5
        public static void M5(this MathThirdParty obj, string str)
        {
            Console.WriteLine(str);
        }
    }



}
