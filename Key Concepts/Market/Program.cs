//крастевици
//домати

//1. входни данни
double tomatoPrice = double.Parse(Console.ReadLine());
double tomatoQuantity = double.Parse(Console.ReadLine());
double cucumberPrice = double.Parse(Console.ReadLine());
double cucumberQuantity = double.Parse(Console.ReadLine());

//2. общата сума на зеленчуците = сумата за доматите + сумата за крастевицитре
double totalSum = (tomatoPrice * tomatoQuantity) + (cucumberPrice * cucumberQuantity);

//3. отпечатване
Console.WriteLine($"{totalSum:F2}");