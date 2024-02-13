int countTabs = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());


for (int tab = 1; tab <= countTabs; tab++)
{
    string nameTab = Console.ReadLine();

    if (nameTab == "Facebook")
    {
        salary -= 150;
    }
    else if (nameTab == "Instagram")
    {
        salary -= 100;
    }
    else if (nameTab == "Reddit")
    {
        salary -= 50;
    }
    if (salary <= 0)
    {
        Console.WriteLine("You have lost your salary.");
        break;
    }

}
if (salary > 0)
    Console.WriteLine(salary);
