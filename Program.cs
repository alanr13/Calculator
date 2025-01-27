using System.Data;
string? input;
int number1, number2;

Console.WriteLine("***********************************");
Console.WriteLine("Calculator\n");
Console.WriteLine("What kind of operation would you like to perform?");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
Console.WriteLine("5. Modulo Division");
string? choice = Console.ReadLine();
Console.Clear();

Console.WriteLine("Enter first number");
input = Console.ReadLine();
number1 = int.Parse(input);

Console.WriteLine("\nEnter second number");
input = Console.ReadLine();
number2 = int.Parse(input);
Console.Clear();

switch(choice)
{
    case "1":
        Console.WriteLine(number1 + number2);
        break;
    case "2":
        Console.WriteLine(number1  - number2);
        break;
    case "3":
        Console.WriteLine(number1 * number2);
        break;
    case "4":
        Console.WriteLine(number1 / number2);
        break;
    case "5":
        Console.WriteLine(number1 % number2);
        break;
    default:
        Console.WriteLine("There no that kind of operation.");
        break;
}