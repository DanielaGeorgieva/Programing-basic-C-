int countPages = int.Parse(Console.ReadLine());
int pagesForOneHour = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());

int neededHours = countPages / pagesForOneHour;
int neededDays = neededHours / days;

Console.WriteLine(neededDays);