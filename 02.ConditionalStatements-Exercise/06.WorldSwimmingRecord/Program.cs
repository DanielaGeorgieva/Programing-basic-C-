double recordInSec = double.Parse(Console.ReadLine());
double distanceInMetres = double.Parse(Console.ReadLine());
double timeInSecondForOneMeter = double.Parse(Console.ReadLine());

double timeForSwim = distanceInMetres * timeInSecondForOneMeter;
double delay = Math.Floor(distanceInMetres / 15);
double finalTimeForSwimming = timeForSwim + delay * 12.5;

if (finalTimeForSwimming < recordInSec)
{
    Console.WriteLine($" Yes, he succeeded! The new world record is {finalTimeForSwimming:F2} seconds.");
}
else
{
    double neededTime = finalTimeForSwimming - recordInSec;
    Console.WriteLine($"No, he failed! He was {neededTime:F2} seconds slower.");
}
//•	Ако Иван е подобрил Световния рекорд (времето му е по-малко от рекорда) отпечатваме:
//  " Yes, he succeeded! The new world record is {времето на Иван} seconds."
//	Ако НЕ е подобрил рекорда (времето му е по-голямо или равно на рекорда) отпечатваме:
//  "No, he failed! He was {недостигащите секунди} seconds slower."
