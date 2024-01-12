int qualityNylon = int.Parse(Console.ReadLine());
int qualityPaint = int.Parse(Console.ReadLine());
int qualityТhinner = int.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());

double priceNylon = 1.50;
double pricePaint = 14.50;
double priceThinner = 5.00;
double priceBag = 0.40;
double neededSum = ((qualityNylon + 2) * priceNylon) + ((qualityPaint + (qualityPaint * 0.10)) * pricePaint) + (qualityТhinner * priceThinner) + priceBag;
double priceForWorkers = (neededSum * 0.30) * hours;
double totalSum = neededSum + priceForWorkers;

Console.WriteLine(totalSum);