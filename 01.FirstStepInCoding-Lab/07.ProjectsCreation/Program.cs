string nameArchitect = Console.ReadLine();
int countProjects = int.Parse(Console.ReadLine());
int timeForOneProject = 3;
int timeForAllProjects = countProjects * timeForOneProject;

Console.WriteLine($"The architect {nameArchitect} will need {timeForAllProjects} hours to complete {countProjects} project/s.");
