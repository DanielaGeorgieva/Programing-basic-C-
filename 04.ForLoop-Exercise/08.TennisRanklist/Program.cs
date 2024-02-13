int countTournirs = int.Parse(Console.ReadLine());
int startPoints = int.Parse(Console.ReadLine());

int totalWins = 0;
int points = startPoints;

for (int tournir = 1; tournir <= countTournirs; tournir++)
{
    string faza = Console.ReadLine();
    switch (faza)
    {
        case "W":
        points += 2000;
            totalWins++;
            break;

        case "F":
   
        points += 1200;
            break;

        case "SF":
    
        points += 720;
            
            break;
            
    }
}
int averagePoints = (points - startPoints) / countTournirs;
double winPercentage = (double)totalWins / countTournirs * 100;

Console.WriteLine($"Final points: {points}");
Console.WriteLine($"Average points: {averagePoints}");
Console.WriteLine($"{winPercentage:f2}%");