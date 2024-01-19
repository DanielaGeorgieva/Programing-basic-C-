int sumPerYear = int.Parse(Console.ReadLine());

double shoes = sumPerYear - (sumPerYear * 0.40);
double equipment = shoes - (shoes * 0.20);
double ball = equipment / 4;
double accessories = ball / 5;

double allSum = sumPerYear + shoes + equipment + ball + accessories;

Console.WriteLine(allSum);
