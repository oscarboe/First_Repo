// See https://aka.ms/new-console-template for more information

using Hand_calculator;

Calculator cal = new Calculator();
double a = 5;
double b = 6;
Console.WriteLine("add: " + cal.Add(a, b) + "\nSubstract: "
    + cal.Subtract(a, b) + "\nMultiply:" + cal.Multiply(a, b)+"\npower: " + cal.Power(a, b));