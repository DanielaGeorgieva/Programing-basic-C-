string month = Console.ReadLine();
int countNight = int.Parse(Console.ReadLine());
double studio = 0;
double apartment = 0;

switch (month)
{
    case "May":
    case "October":
        studio = 50;
        apartment = 65;

        if (countNight > 7 && countNight <= 14)
        {
            studio *= 0.95;
        }
        else if (countNight > 14)
        {
            studio *= 0.70;
            apartment *= 0.90;
        }
        break;

    case "June":
    case "September":
        studio = 75.20;
        apartment = 68.70;
 

        if (countNight > 14)
        {
            studio *= 0.80;
            apartment *= 0.90;
        }
        break;

    case "July":
    case "August":
        {
            studio = 76;
            apartment = 77;
        }

        if (countNight > 14)
            apartment *= 0.90;

        break;
}
double allNightS = studio * countNight;
double allNightA = apartment * countNight;
Console.WriteLine($"Apartment: {allNightA:f2} lv.");
Console.WriteLine($"Studio: {allNightS:f2} lv.");
