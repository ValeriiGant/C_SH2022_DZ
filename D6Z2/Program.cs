// Задание 2. Задать двумерный массив следующим правилом: Aₘₙ = m+n
Console.Clear();
int[,] ArrayMain(int[,] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк двухмерного массива: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите кол-во столбцов двухмерного массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] arraymn = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arraymn[i, j] = i + j;
    }
}
ArrayMain(arraymn, 10, 90 );
Console.WriteLine($"Двумерный массив правилом: A = m [{m}] + n [{n}]: ");
PrintArray(arraymn);


