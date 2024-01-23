
string nameSerial = Console.ReadLine();
int longTimeSeries = int.Parse(Console.ReadLine());
int timeRest = int.Parse(Console.ReadLine());

double lunch = timeRest / 8.0;
double rest = timeRest / 4.0;

double neededTime = longTimeSeries + lunch + rest;

double difference = Math.Abs(neededTime - timeRest);

if (neededTime <= timeRest)
{
    
    Console.WriteLine($"You have enough time to watch {nameSerial} and left with {Math.Ceiling(difference)} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {nameSerial}, you need {Math.Ceiling(difference)} more minutes.");
}