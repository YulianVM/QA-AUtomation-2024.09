Console.Write("Моля, въведете първото число: ");
double firstNumber = double.Parse(Console.ReadLine());
Console.Write("Моля, въведете второто число: ");
double secondNumber = double.Parse(Console.ReadLine());

//събиране
double sum = firstNumber + secondNumber;

//изваждане
double diff = firstNumber - secondNumber;

//умножение
double product = firstNumber * secondNumber;

//деление
double division = firstNumber / secondNumber;


Console.WriteLine($"{firstNumber:F2} + {secondNumber:F2} = {sum:F2}");
Console.WriteLine($"{firstNumber:F2} - {secondNumber:F2} = {diff:F2}");
Console.WriteLine($"{firstNumber:F2} * {secondNumber:F2} = {product:F2}");
Console.WriteLine($"{firstNumber:F2} / {secondNumber:F2} = {division:F2}");



Console.ReadKey();