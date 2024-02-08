int n = int.Parse(Console.ReadLine());
int left = 0;
int right = 0;

for (int i = 0; i < n; i++)
{
    int currentNum = int.Parse(Console.ReadLine());
    left += currentNum;
}
for (int i = 0; i < n; i++)
{
    int currentNum = int.Parse(Console.ReadLine());
    right += currentNum;
}
if (left == right)
{
    Console.WriteLine($"Yes, sum = {left} ");
}
else
{
    int difference = Math.Abs(left - right);
    Console.WriteLine($"No, diff = {difference}");
}