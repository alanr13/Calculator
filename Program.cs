using System.Data;
string? input;
int quantityOfOperations;
int result = 0;

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

switch(choice)
{
    case "1":
        NumberQuantityQuestion();
        input = Console.ReadLine();
        Console.Clear();

        quantityOfOperations = int.Parse(input!);
        for (int i = 1; i <= quantityOfOperations; i++)
        {
            input = Console.ReadLine();
            result += int.Parse(input!);
        }
        Console.WriteLine(result);
        break;
    case "2":
        NumberQuantityQuestion();
        input = Console.ReadLine();
        Console.Clear();

        quantityOfOperations = int.Parse(input!);
        for (int i = 1; i <= quantityOfOperations; i++)
        {
            input = Console.ReadLine();
            result -= int.Parse(input!);
        }
        Console.WriteLine(result);
        break;
    case "3":
        NumberQuantityQuestion();
        input = Console.ReadLine();
        Console.Clear();
        result = 1;

        quantityOfOperations = int.Parse(input!);
        for (int i = 1; i <= quantityOfOperations; i++)
        {
            input = Console.ReadLine();
            result *= int.Parse(input!);
        }
        Console.WriteLine(result);
        break;
    case "4":
        NumberQuantityQuestion();
        input = Console.ReadLine();
        Console.Clear();

        quantityOfOperations = int.Parse(input!);
        for (int i = 1; i <= quantityOfOperations; i++)
        {
            input = Console.ReadLine();
            result /= int.Parse(input!);
        }
        Console.WriteLine(result);
        break;
    case "5":
        NumberQuantityQuestion();
        input = Console.ReadLine();
        Console.Clear();

        quantityOfOperations = int.Parse(input!);
        for (int i = 1; i <= quantityOfOperations; i++)
        {
            input = Console.ReadLine();
            result %= int.Parse(input!);
        }
        Console.WriteLine(result);
        break;
    default:
        Console.WriteLine("There no that kind of operation.");
        break;
}

void NumberQuantityQuestion()
{
    Console.WriteLine("On how many number would you like to perform an operation?");
}