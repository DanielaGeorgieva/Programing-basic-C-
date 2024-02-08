int n = int.Parse(Console.ReadLine());

int oddSum = 0;
int evenSum = 0;

for (int i = 0; i < n; i++)
{
    int currentNum = int.Parse(Console.ReadLine());
    
    if (i % 2 == 0)
    {
        evenSum += currentNum;
    }
    else
    {
        oddSum += currentNum;
    }
}
if (oddSum == evenSum)
{
    Console.WriteLine($"Yes ");
    Console.WriteLine($"Sum = {oddSum} ");
}
else
{
    int difference = Math.Abs(oddSum - evenSum);
    Console.WriteLine($"No ");
    Console.WriteLine($"Diff = {difference}");
}
