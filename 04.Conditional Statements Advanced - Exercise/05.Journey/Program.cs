double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();
string destination = "";
string typeRest = "";

if (budget <= 100)
{
    destination = "Bulgaria";

    switch (season)
    {
        case "summer":
            budget *= 0.30;
            typeRest = "Camp";
            break;
        case "winter":
            budget *= 0.70;
            typeRest = "Hotel";
            break;
    }
}
else if (budget <= 1000)
{
    destination = "Balkans";

    switch (season)
    {
        case "summer":
            budget *= 0.40;
            typeRest = "Camp";
            break;
        case "winter":
            budget *= 0.80;
            typeRest = "Hotel";
            break;
    }
}
else if (budget > 1000)

{
    destination = "Europe";
    budget *= 0.90;
    typeRest = "Hotel";
}
    Console.WriteLine($"Somewhere in {destination}");
    Console.WriteLine($"{typeRest} - {budget:f2}");

