using System.ComponentModel.Design;
using System.Dynamic;

string flowers = Console.ReadLine();
int countFlowers = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

double totalSum = 0;
//"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
double rosePrice = 5.0;
double dahliaPrice = 3.80;
double tulipPrice = 2.80;
double narcissusPrice = 3.0;
double gladiolusPrice = 2.50;

switch (flowers)
{
    case "Roses":
        totalSum = countFlowers * rosePrice;
        if (countFlowers > 80)
        {
            totalSum *= 0.90;
        }
        break;

    case "Dahlias":
        totalSum = countFlowers * dahliaPrice;
        if (countFlowers > 90)
        {
            totalSum *= 0.85;
        }
        break;
    case "Tulips":
        totalSum = countFlowers * tulipPrice;
        if (countFlowers > 80)
        {
            totalSum *= 0.85;
        }
        break;
    case "Narcissus":
        totalSum = countFlowers * narcissusPrice;
        if (countFlowers < 120)
        {
            totalSum *= 1.15;
        }
        break;
    case "Gladiolus":
        totalSum = countFlowers * gladiolusPrice;
        if (countFlowers < 80)
        {
            totalSum *= 1.20;
        }
        break;
}

if (budget >= totalSum)
{
    double restBudget = Math.Abs(budget - totalSum);
    Console.WriteLine($"Hey, you have a great garden with {countFlowers} {flowers} and {restBudget:f2} leva left.");
}
else
{
    double neededMoney = Math.Abs(budget - totalSum);
    Console.WriteLine($" Not enough money, you need {neededMoney:f2} leva more.");
}
    