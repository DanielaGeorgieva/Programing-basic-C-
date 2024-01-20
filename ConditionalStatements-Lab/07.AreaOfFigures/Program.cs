string figure = Console.ReadLine();

double area = 0;

if (figure == "square")
{
    double num = double.Parse(Console.ReadLine());
    area = num * num;
    Console.WriteLine($" {area:f3}");
}
else if (figure == "rectangle")
{
    double numA = double.Parse(Console.ReadLine());
    double numB = double.Parse(Console.ReadLine());
    area = numA * numB;
    Console.WriteLine($" {area:f3}");
}
else if (figure == "circle")
{
    double radius = double.Parse(Console.ReadLine());
    area = Math.PI * radius * radius;
    Console.WriteLine($" {area:f3}");
}
else if (figure == "triangle")
{
    double sideA = double.Parse(Console.ReadLine());
    double hight = double.Parse(Console.ReadLine());
    area = sideA * hight / 2;
        Console.WriteLine($" {area:f3}");
}