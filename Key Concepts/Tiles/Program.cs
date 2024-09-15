//1. входни данни
double bathroomWidth = double.Parse(Console.ReadLine());
double bathroomHeight = double.Parse(Console.ReadLine());
double tileWidth = double.Parse(Console.ReadLine());
double tileHeight = double.Parse(Console.ReadLine());

//2. намиране на площа в банята
double bathArea = bathroomWidth * bathroomHeight; //създаваме променлива и създаваме стойност

//3. Добавяме 10% = 0.1 повече за покриване
bathArea = bathArea + 0.10 * bathArea; //променяме стойноста на вече съществуващата променлива
//bathArea = 1.10 * bathArea; - може да го записхем и по този начин

//4. намиране площа на една плочка
double tileArea = tileWidth * tileHeight;

//5.изчислявам нужните плочки
double countTiles = bathArea / tileArea;

//6. otpeàtwame (закръгляне)
Console.WriteLine(Math.Round(countTiles));

