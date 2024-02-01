string tipProjection = Console.ReadLine();
int lines = int.Parse(Console.ReadLine());
int columns = int.Parse(Console.ReadLine());
double priceTicket = 0.0;
if (tipProjection == "Premiere")
{
    priceTicket = 12.00;
}
else if (tipProjection == "Normal")
{
    priceTicket = 7.50;
}
else if (tipProjection == "Discount")
{
    priceTicket = 5.00;
}
double totalSum = lines * columns * priceTicket;
Console.WriteLine($"{totalSum:F2}");