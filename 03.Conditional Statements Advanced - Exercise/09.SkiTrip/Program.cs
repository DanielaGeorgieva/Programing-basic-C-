int dayRest = int.Parse(Console.ReadLine());
string typeRoom = Console.ReadLine();
string mark = Console.ReadLine();

double price = 0;

switch (typeRoom)
{
    case "room for one person":
        {
            price = 18.00 * (dayRest - 1);
        }
        break;

    case "apartment":
        {
            price = 25.00 * (dayRest - 1);
            if (dayRest < 10)
                price *= 0.70;
            else if (dayRest >= 10 && dayRest <= 15)
                price *= 0.65;
            else if (dayRest > 15)
                price *= 0.50;
        }
        break;
  
    case "president apartment":
        price = 35.00 * (dayRest - 1);
        if (dayRest < 10)
            price *= 0.90;
        else if (dayRest >= 10 && dayRest <= 15)
            price *= 0.85;
        else if (dayRest > 15)
            price *= 0.80;
        break;
}
if (mark == "positive")
    price *= 1.25;
else if (mark == "negative")
    price *= 0.90;

Console.WriteLine($"{price:f2}");