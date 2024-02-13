int countTabs = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());

string nameTab = Console.ReadLine();
int fine = 0;

for (int i = 1; i <= countTabs; i++)
{
    if (nameTab == "Facebook")
    {
        fine = 150;
        salary -= fine;
    }
    else if (nameTab == "Instagram")
    {
        fine = 100;
        salary -= fine;
    }
    else if (nameTab == "Reddit")
    {
        fine -= 50;
        salary = fine;
    }

}
if (salary == 0)
    Console.WriteLine("You have lost your salary.");
else
    Console.WriteLine(salary - fine);
