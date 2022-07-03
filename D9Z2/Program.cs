// Задание 2. Найти сумму элементов от M до N, N и M заданы
Console.Clear();
int SumbyMN(int m, int n)
{   
    if(m == n) return m;
    return m + SumbyMN(m + 1, n);
}

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write($"Сумма элементов от М = {m} до N = {n}: " );
int sum = SumbyMN(m,n);
Console.WriteLine(sum);