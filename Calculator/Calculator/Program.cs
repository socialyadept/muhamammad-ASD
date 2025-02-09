// See https://aka.ms/new-console-template for more information
using Calculator.Core;

Console.WriteLine("Hello, World!");
int sum = Calculator.Core.Calculator.Add(1, 2);
Console.WriteLine($"Sum of 1 and 2 is {sum}");

//double divide = Calculator.Core.Calculator.Divide(1, 0);
//Console.WriteLine($"Divide of 1 and 0 is {divide}");

double mul = Calculator.Core.Calculator.Multiply(2, 1);
Console.WriteLine($"Multiplication of 1 and 2 is {mul}");

int sub = Calculator.Core.Calculator.Subtract(2, 1);
Console.WriteLine($"Subtraction of 2 and 1 is {sub}");
