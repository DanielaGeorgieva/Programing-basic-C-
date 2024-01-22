double vacationPrice = double.Parse(Console.ReadLine());
int countPuzzels = int.Parse(Console.ReadLine());
int countDolls = int.Parse(Console.ReadLine());
int countBears = int.Parse(Console.ReadLine());
int countMinions = int.Parse(Console.ReadLine());
int countTrucks = int.Parse(Console.ReadLine());

double pricePuzzels = countPuzzels * 2.6;
double priceDolls = countDolls * 3.0;
double priceBears = countBears * 4.10;
double priceMinions = countMinions * 8.2;
double priceTrucks = countTrucks * 2.0;

double incom = pricePuzzels + priceDolls + priceBears + priceMinions + priceTrucks;

int allToys = countPuzzels + countDolls + countBears + countMinions + countTrucks;

if (allToys >= 50)
{
    incom *= 0.75;
}
double rent = incom * 0.1;

double totalSum = incom - rent;

if (totalSum >= vacationPrice)
{
    Console.WriteLine($"Yes! {totalSum - vacationPrice:F2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {vacationPrice - totalSum:F2} lv needed.");
}