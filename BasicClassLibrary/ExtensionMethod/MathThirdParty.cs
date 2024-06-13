namespace BasicClassLibrary
{
    public class MathThirdParty
    {
        /// <summary>
        /// This is an Add method to add two numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>number</returns>
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        /// <summary>
        /// This is an Multiply method to multiply two numbers
        /// </summary>
        /// <param name="num1">num1</param>
        /// <param name="num2">num2</param>
        /// <returns>number</returns>
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }


        // Method 1
        public void M1()
        {
            Console.WriteLine("Method Name: M1");
        }

        // Method 2
        public void M2()
        {
            Console.WriteLine("Method Name: M2");
        }

        // Method 3
        public void M3()
        {
            Console.WriteLine("Method Name: M3");
        }
    }
}