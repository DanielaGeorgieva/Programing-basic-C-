string day = Console.ReadLine();
// Monday	Tuesday	Wednesday	Thursday	Friday	Saturday	Sunday
//12         12     14          14           12      16          16
int price = 0;

if (day == "Monday" || day == "Tuesday" || day == "Friday")
{
    price = 12;
}
else if (day == "Wednesday" || day == "Thursday")
{
    price = 14;
}
else if (day == "Saturday" || day == "Sunday")
{
    price = 16;
}
Console.WriteLine(price);