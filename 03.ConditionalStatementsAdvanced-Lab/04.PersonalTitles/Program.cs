double age = double.Parse(Console.ReadLine());
string sex = Console.ReadLine();

if (sex == "m")
if (age >= 16)
{
        Console.WriteLine("Mr.");
    }
if (sex == "m" && age < 16)
    {
        Console.WriteLine("Master");
    }
else if (sex == "f" && age >= 16)
{
    Console.WriteLine("Ms.");
}
else if (sex == "f" && age < 16)
{
    Console.WriteLine("Miss");
}