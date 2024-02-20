using System.Reflection.Metadata.Ecma335;

string name = Console.ReadLine();

int klas = 1;
double badMarkCount = 0;
double totalMarks = 0;


while (klas <= 12)
{
    double mark = double.Parse(Console.ReadLine());

    if (mark >= 4)
    {
        totalMarks += mark;
        klas++;
        badMarkCount = 0;
        continue;

    }

    else if (mark < 4)
    {
        badMarkCount++;
        if (badMarkCount >= 2)
        {
            Console.WriteLine($"{name} has been excluded at {klas} grade");
            break;
        }

    }
}
if (klas >= 12)
{
    double avarage = totalMarks / 12;
    Console.WriteLine($"{name} graduated. Average grade: {avarage:f2}");
}