string name = Console.ReadLine();
double points = double.Parse(Console.ReadLine());
int judgesCount = int.Parse(Console.ReadLine());

double totalPoints = points;

for (int i = 0; i < judgesCount; i++)
{
    string judgeName = Console.ReadLine();
    double judgePoints = double.Parse(Console.ReadLine());

    totalPoints += judgeName.Length * judgePoints / 2;


    if (totalPoints >= 1250.5)
    {
        Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {totalPoints:f1}!");
        break;
    }
}
  if (totalPoints < 1250.5)
    {
        double neededPoints = 1250.5 - totalPoints;
        Console.WriteLine($"Sorry, {name} you need {neededPoints:f1} more!");
    }
