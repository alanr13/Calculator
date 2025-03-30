string? input;
bool isFirstNumber = true;
string? operationType = "n";
double num;
double result = 0;
for (;;)
{
    for(;;)
    {
        int value;
        input = Console.ReadLine();
        if(int.TryParse(input, out value))
        {
            num = int.Parse(input);
            if(isFirstNumber)
            {
                result = num;
            }
            input = Console.ReadLine();
            if(input == "+" || input == "-" || input == "*" && input != "=")
            {
                operationType = input;
                switch (operationType)
                {
                    case "+":
                        result += Add(num);
                        break;
                    case "-":
                        result -= Subtract(num);
                        break;
                    case "*":
                        result *= Multiply(num);
                        break;
                    default:
                        Console.WriteLine("I don't recognize that sign.");
                        break;
                }
                break;
            }
            else if(input == "=")
            {
                break;
            }
        }
        isFirstNumber = false;
    }
    if (input == "=")
    {
        switch (operationType)
        {
            case "+":
                result += Add(num);
                isFirstNumber = false;
                break;
            case "-":
                result -= Subtract(num);
                isFirstNumber = false;
                break;
            case "*":
                result *= Multiply(num);
                isFirstNumber = false;
                break;
            default:
                Console.WriteLine("I don't recognize that sign.");
                break;
        }
        break;
    }
   
}
Console.WriteLine(result);
double Add(double num)
{
    return num + 0;
}

double Subtract(double num)
{
    return num - 0;
}

double Multiply(double num)
{
    return 1 * num;
}
