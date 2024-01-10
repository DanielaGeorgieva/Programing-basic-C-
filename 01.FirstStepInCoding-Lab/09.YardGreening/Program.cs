double allYard = double.Parse(Console.ReadLine());

double sumAllYard = allYard * 7.61;
double discount = sumAllYard * 0.18;
double sumWithDiscount = sumAllYard - discount;

Console.WriteLine($"The final price is: {sumWithDiscount} lv.");
Console.WriteLine($"The discount is: {discount} lv.");
