// Задание 1. Показать натуральные числа от M до N, N и M заданы
Console.Clear();
string Digits(int m, int n)
{
    if(m == n) return m.ToString();
    return m.ToString() + " " + Digits(m + 1, n);
}

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write($"Натуральные числа от М = {m} до N = {n}: " );
Console.WriteLine(Digits(m,n));