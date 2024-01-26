using System;

double budget = double.Parse(Console.ReadLine());
string category = Console.ReadLine();
int countPersonInGroup = int.Parse(Console.ReadLine());

double transportPercentage = 0.0;

if (countPersonInGroup <= 4)
{
    transportPercentage = 0.75;
}
else if (countPersonInGroup  >= 5 && countPersonInGroup <= 9)
{
    transportPercentage = 0.60;
}
else if (countPersonInGroup >= 10 && countPersonInGroup <= 24)
{
    transportPercentage = 0.50;
}
else if (countPersonInGroup >= 25 && countPersonInGroup <= 49)
{
    transportPercentage = 0.40;
}
else if (countPersonInGroup >= 50)
{
    transportPercentage = 0.25;
}
double transportCost = budget * transportPercentage;
budget -= transportCost;

double ticketCost = 0.0;

if (category == "VIP")
{
    ticketCost = 499.99;
}
else
{
    ticketCost = 249.99;
}

double totalTicketCost = countPersonInGroup * ticketCost;

// Изчисляване на оставащия бюджет
double remainingBudget = budget - totalTicketCost;

// Изход
if (remainingBudget >= 0)
{
    Console.WriteLine($"Yes! You have {remainingBudget:F2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {Math.Abs(remainingBudget):F2} leva.");
}

