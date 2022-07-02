// Задание 2. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
Console.Clear();
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void GotoMinElementsArray(int[,] matr, int row)
{
    int jLow = 0;
    int matrLow = 0;
    int tmp = 0;
    int length = matr.GetLength(1);
    while (length > 0)
    {
        matrLow = matr[row, 0];
        jLow = 0;
        for (int j = 0; j < length; j++)
        {
            if (matr[row, j] < matrLow)
            {
                jLow = j;
                matrLow = matr[row, j];
            }

        }
        tmp = matr[row, length - 1];
        matr[row, length - 1] = matr[row, jLow];
        matr[row, jLow] = tmp;
        length--;
    }
}
Console.Clear();
Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов: ");
int k = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int[,] matrix = new int[n, k];
FillArray(matrix);
Console.WriteLine("Первоначальный массив: ");
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
for (int i = 0; i < n; i++)
    GotoMinElementsArray(matrix, i);
Console.WriteLine("Упорядоченный массив по убыванию элементов каждой строки: ");
Console.WriteLine();
PrintArray(matrix);
