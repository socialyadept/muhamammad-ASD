// See https://aka.ms/new-console-template for more information
namespace Calculator.Core

{
    public class Calculator
    {
        public static int Add(int a, int b)
        {
            checked { return a + b; }
        }

        public static double Divide (int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("You cannot divide by zero");
            }

            return (double)a / (double)b;   
        }

        public static double Multiply(int a, int b)
        {
            checked { return a * b; }
        }

        public static int Subtract(int a, int b) { 
            checked { return a - b; }
        }
    }
}