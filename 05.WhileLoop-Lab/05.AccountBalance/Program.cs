string input = Console.ReadLine();
double bankAcc = 0;

while (input != "NoMoreMoney")
{
    double currentNum = double.Parse(input);
    
    if (currentNum < 0)
    {
        Console.WriteLine("Invalid operation!");
        break;
    }
    bankAcc += currentNum;
    Console.WriteLine($"Increase: {currentNum:f2}");
    input = Console.ReadLine();
    
}

Console.WriteLine($"Total: {bankAcc:f2}");