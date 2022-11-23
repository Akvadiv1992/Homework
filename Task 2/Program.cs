Console.Clear();
Console.Write("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c)
Console.WriteLine($"наибольшее число: {a}");
if (b > a && b > c)
Console.WriteLine($"наибольшее число: {b}");
if (c > a && c > b)
Console.WriteLine($"наибольшее число: {c}");