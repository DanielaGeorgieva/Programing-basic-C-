double depositeSum = double.Parse(Console.ReadLine());
int term = int.Parse(Console.ReadLine());
double interestRate = double.Parse(Console.ReadLine())/100;
//сума = депозирана сума + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)
double sum;
sum = depositeSum + term * (depositeSum * interestRate / 12);
Console.WriteLine(sum);