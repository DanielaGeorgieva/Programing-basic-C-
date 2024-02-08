using System.Threading.Channels;

int ageLily = int.Parse(Console.ReadLine());
double priceWashingMachine = double.Parse(Console.ReadLine());
int toyPrice = int.Parse(Console.ReadLine());

int money = 0;

for (int i = 1; i <= ageLily; i++)
{
    if (i % 2 == 0)
        money += i * 5 - 1;
    else
        money += toyPrice;
}
if (money >= priceWashingMachine)

    Console.WriteLine($"Yes! {money - priceWashingMachine:f2}");
else

    Console.WriteLine($"No! {priceWashingMachine - money:f2}" );
