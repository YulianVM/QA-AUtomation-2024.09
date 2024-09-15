//1. входни данни
double depositAmount = Double.Parse(Console.ReadLine());
int mounts = int.Parse(Console.ReadLine());
double AnnualRate = double.Parse(Console.ReadLine()) / 100; //5.7 / 100 = 0.057

//2 изчисляване сумата след депозита
double finalSum = depositAmount +  mounts * (depositAmount * AnnualRate) / 12;

//3. otpeàtwane na sumata sled depozita
Console.WriteLine($"{finalSum:F2}");
