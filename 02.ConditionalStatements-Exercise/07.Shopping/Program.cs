double budget = double.Parse(Console.ReadLine());
int videoCardCount = int.Parse(Console.ReadLine());
int processorsCount = int.Parse(Console.ReadLine());
int ramMemoryCount = int.Parse(Console.ReadLine());

double priceCards = videoCardCount * 250;
double priceProcessor = priceCards * 0.35;
double priceRam = priceCards * 0.10;

double neededSum = (priceCards + (processorsCount * priceProcessor) + (ramMemoryCount * priceRam));

if (videoCardCount > processorsCount)
{
    neededSum *= 0.85;
}

if (budget >= neededSum)
{
    double totalSum = Math.Abs(neededSum - budget);
    Console.WriteLine($"You have {totalSum:F2} leva left!");
}
else
{
    double totalSum = Math.Abs(neededSum - budget);
    Console.WriteLine($"Not enough money! You need {totalSum:F2} leva more!");
}