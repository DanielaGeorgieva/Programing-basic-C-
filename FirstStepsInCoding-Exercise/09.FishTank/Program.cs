int lenght = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int hight = int.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine());

int volume = lenght * width * hight;
double litres = volume * 0.001;
double allLitres = litres * (1 - percent / 100);
Console.WriteLine(allLitres);
