Console.Clear();
Console.Write("Введите число 1: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int m = Convert.ToInt32(Console.ReadLine());

if (n > m)
Console.WriteLine($"наибольшее число: {n}");
if (m > n)
Console.WriteLine($"наибольшее число: {m}");
if (n < m)
Console.WriteLine($"наименьшее число: {n}");
if (m < n)
Console.WriteLine($"наименьшее число {m}");