// See https://aka.ms/new-console-template for more information
using MathOperation;
using System.Runtime.CompilerServices;

Calc c = new Calc();
Console.WriteLine(" Choose the opertation ");
Console.WriteLine(" a: Sum ");
Console.WriteLine(" b: minus");
Console.WriteLine(" c: Multiply");
Console.WriteLine(" d: mod ");
Console.WriteLine(" e: minimum");
Console.WriteLine(" f: maximum");
Console.WriteLine("           ");
String choice = Console.ReadLine();
if (choice == "a")
{
    Console.WriteLine("please enter first number");
    String s1 = Console.ReadLine();
    int num1 = Convert.ToInt32(s1);
    Console.WriteLine("please enter second number");
    String s2 = Console.ReadLine();
    int num2 = Convert.ToInt32(s2);
    int result = c.sum(num1, num2);
    Console.WriteLine(" The sum " + num1 + " + " + num2 + " = " + result);
}
else if (choice == "b")
{
    Console.WriteLine("Enter the first number");
    String s1 = Console.ReadLine();
    int num1 = Convert.ToInt32(s1);
    Console.WriteLine("Enter the second number");
    String s2 = Console.ReadLine();
    int num2 = Convert.ToInt32(s2);
    int result = c.minus(num1, num2);
    Console.WriteLine(" The sub of " + num1 + " - " + num2 + " = " + result);
}
else if (choice == "c")
{
    Console.WriteLine("Please enter first number");
    String s1 = Console.ReadLine();
    int num1 = Convert.ToInt32(s1);
    Console.WriteLine("please enter first number");
    String s2 = Console.ReadLine();
    int num2 = Convert.ToInt32(s2);
    int res = c.mult(num1, num2);
    Console.WriteLine(" the mult of " + num1 + " * " + num2 + " = " + res);

}
else if (choice == "d")
{
    Console.WriteLine("Enter the first number");
    String s1 = Console.ReadLine();
    int num1 = Convert.ToInt32(s1);
    Console.WriteLine(" Enter the second number");
    String s2 = Console.ReadLine();
    int num2 = Convert.ToInt32(s2);
    int result = c.mod(num1, num2);
    Console.WriteLine(" The mod of " + num1 + " % " + num2 + " = " + result);
}
else if ( choice== "e")
{
    Console.WriteLine("Please Enter the first number");
    String s1 = Console.ReadLine();
    int num1 = Convert.ToInt32(s1);
    Console.WriteLine(" Please enter the second number");
    String s2 = Console.ReadLine();
    int num2 = Convert.ToInt32(s2);
    int res = c.min(num1, num2);
    Console.WriteLine(" the minus number between " + num1 + " and " + num2 + " is " + res);
}
else if (choice == "f")
{
    Console.WriteLine(" Enter the first number");
    String s1 = Console.ReadLine();
    int num1 = Convert.ToInt32(s1);
    Console.WriteLine(" Please enter the second number");
    String s2 = Console.ReadLine();
    int num2 = Convert.ToInt32(s2);
    int res = c.max(num1, num2);
    Console.WriteLine(" the maximum of " + num1 + " and " + num2 + " is " + res);
}
else
{
    Console.WriteLine(" invalid choice ");
}


