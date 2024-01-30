int numOne = int.Parse(Console.ReadLine());
int numTwo = int.Parse(Console.ReadLine());
char symbol = char.Parse(Console.ReadLine());

double calculation = 0.0;
switch (symbol)
{
    case '+':
        calculation = numOne + numTwo;
        if (calculation % 2 == 0)

            Console.WriteLine($"{numOne} + {numTwo} = {calculation} - even");
        else
            Console.WriteLine($"{numOne} + {numTwo} = {calculation} - odd");
        break;
    case '-':
        calculation = numOne - numTwo;
        if (calculation % 2 == 0)

            Console.WriteLine($"{numOne} - {numTwo} = {calculation} - even");
        else
            Console.WriteLine($"{numOne} - {numTwo} = {calculation} - odd");
        break;
    case '*':
        calculation = numOne * numTwo;
        if (calculation % 2 == 0)

            Console.WriteLine($"{numOne} * {numTwo} = {calculation} - even");
        else
            Console.WriteLine($"{numOne} * {numTwo} = {calculation} - odd");
        break;

    case '/':
        if (numTwo != 0)
        {
            calculation = (double)numOne / numTwo;
            Console.WriteLine($"{numOne} / {numTwo} = {calculation:f2}");
        }
        else
            Console.WriteLine($"Cannot divide {numOne} by zero");
        break;

    case '%':
        if (numTwo != 0)
        {
            calculation = (double)numOne % numTwo;
            Console.WriteLine($"{numOne} % {numTwo} = {calculation}");
        }

        else
            Console.WriteLine($"Cannot divide {numOne} by zero");
        break;
}