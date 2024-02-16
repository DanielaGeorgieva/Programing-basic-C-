using System.Xml.Schema;

string input = Console.ReadLine();
int minNum = int.MaxValue;

while (input != "Stop")
{
    int number = int.Parse(input);

    if (number < minNum)
    {
        minNum = number;
        
    }
    input = Console.ReadLine();
}
Console.WriteLine(minNum);