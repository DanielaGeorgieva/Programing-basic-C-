
int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int countFisherman = int.Parse(Console.ReadLine());
//"Spring", "Summer", "Autumn", "Winter"
double rent = 0;


switch (season)
{
    case "Spring":
    rent = 3000;
        break;
    case "Summer":
    case "Autumn":
        rent = 4200;
        break;
     case "Winter":
        rent = 2600;
        break;

}

if (countFisherman <= 6)
{
    rent *= 0.90;
}
else if (countFisherman <= 11)
{
    rent *= 0.85;
}
else
{
    rent *= 0.75;
}
if (countFisherman % 2 == 0 && season != "Autumn")
{
    rent *= 0.95;
}
double restMoney = Math.Abs(budget - rent);

if (budget >= rent)
    Console.WriteLine($"Yes! You have {restMoney:f2} leva left.");
else
    Console.WriteLine($"Not enough money! You need {restMoney:f2} leva.");