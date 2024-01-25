string fruit = Console.ReadLine();
string day = Console.ReadLine();
double qty = double.Parse(Console.ReadLine());

double totalPrice = 0;
switch(day)
{
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "thursday":
    case "Friday":

        if (fruit == "banana")
            totalPrice = qty * 2.50;
        else if (fruit == "apple")
            totalPrice = qty * 1.20;
        else if (fruit == "orange")
            totalPrice = qty * 0.85;
        else if (fruit == "grapefruit")
            totalPrice = qty * 1.45;
        else if (fruit == "kiwi")
            totalPrice = qty * 2.70;
        else if (fruit == "pineapple")
            totalPrice = qty * 5.50;
        else if (fruit == "grapes")
            totalPrice = qty * 3.85;
        else
            Console.WriteLine("error");
        break;
    case "Saturday":
    case "Sunday":
        if (fruit == "banana")
            totalPrice = qty * 2.70;
        else if (fruit == "apple")
            totalPrice = qty * 1.25;
        else if (fruit == "orange")
            totalPrice = qty * 0.90;
        else if (fruit == "grapefruit")
            totalPrice = qty * 1.60;
        else if (fruit == "kiwi")
            totalPrice = qty * 3;
        else if (fruit == "pineapple")
            totalPrice = qty * 5.60;
        else if (fruit == "grapes")
            totalPrice = qty * 4.20;
        else
            Console.WriteLine("error");
        break;
    default:
            Console.WriteLine("error");
            break;
}
if (totalPrice > 0)
{
Console.WriteLine($"{totalPrice:F2}");
}
