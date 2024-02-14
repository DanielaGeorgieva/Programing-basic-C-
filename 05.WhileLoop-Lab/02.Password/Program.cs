string username = Console.ReadLine();
string password = Console.ReadLine();

while (true)
{
    string input = Console.ReadLine();
    if (input == password)
    {
        Console.WriteLine($"Welcome {username}!");
        break;
    }
}
