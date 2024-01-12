int packagesPen = int.Parse(Console.ReadLine());
int packagesMarkers = int.Parse(Console.ReadLine());
int litres = int.Parse(Console.ReadLine());
int discount = int.Parse(Console.ReadLine());

double pricePen = 5.80;
double priceMarkers = 7.20;
double priceLiter = 1.20;

double neededSum = ((packagesPen * pricePen) + (packagesMarkers * priceMarkers) + (litres * priceLiter));

double totalSum = neededSum - (neededSum * discount / 100);



Console.WriteLine(totalSum);