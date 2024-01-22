double budget = double.Parse(Console.ReadLine());
int statists = int.Parse(Console.ReadLine());
double priceForClothes = double.Parse(Console.ReadLine());

double sumDecor = budget * 0.1;

double sumClothes = statists * priceForClothes;

if (statists >= 150)
{
    sumClothes *= 0.9;
}

double allSum = sumDecor + sumClothes;

double leftSum = budget - allSum;

//•	Ако  парите за декора и дрехите са повече от бюджета:
//   "Not enough money!"
//	"Wingard needs {парите недостигащи за филма} leva more."
//	Ако парите за декора и дрехите са по малко или равни на бюджета:
//  "Action!" 
//	"Wingard starts filming with {останалите пари} leva left."

if (allSum <= budget)
{
    Console.WriteLine($"Action!");
    Console.WriteLine($"Wingard starts filming with {leftSum:F2} leva left.");
}

else
{
    Console.WriteLine($"Not enough money!");
    Console.WriteLine($"Wingard needs { allSum - budget:F2} leva more.");
}

