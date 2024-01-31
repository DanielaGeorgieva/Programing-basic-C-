int examHour = int.Parse(Console.ReadLine());
int examMinute = int.Parse(Console.ReadLine());
int arrivalHour = int.Parse(Console.ReadLine());
int arrivalMinute = int.Parse(Console.ReadLine());

int examTimeInMinutes = examHour * 60 + examMinute;
int arrivalTimeInMinutes = arrivalHour * 60 + arrivalMinute;

int timeDifference = arrivalTimeInMinutes - examTimeInMinutes;

if (timeDifference > 0)
{
    Console.WriteLine("Late");

    if (timeDifference < 60)
    {
        Console.WriteLine($"{timeDifference} minutes after the start");
    }
    else
    {
        int hours = timeDifference / 60;
        int minutes = timeDifference % 60;
        Console.WriteLine($"{hours}:{minutes:D2} hours after the start");
    }
}
else if (timeDifference >= -30)
{
    Console.WriteLine("On time");

    if (timeDifference != 0)
    {
        Console.WriteLine($"{Math.Abs(timeDifference)} minutes before the start");
    }
}
else
{
    Console.WriteLine("Early");

    if (timeDifference > -60)
    {
        Console.WriteLine($"{Math.Abs(timeDifference)} minutes before the start");
    }
    else
    {
        int hours = Math.Abs(timeDifference) / 60;
        int minutes = Math.Abs(timeDifference) % 60;
        Console.WriteLine($"{hours}:{minutes:D2} hours before the start");
    }
}