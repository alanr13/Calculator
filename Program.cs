using System.Data;

int number1, number2;

Console.WriteLine("Calculator");
Console.WriteLine("Enter first number");
number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter first number");
number2 = int.Parse(Console.ReadLine());

Console.WriteLine("What kind of operation would you like to perform?");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
string choice = Console.ReadLine();
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
    default:
        Console.WriteLine("There no that kind of operation.");
        break;
}