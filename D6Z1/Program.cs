//Задание 1. Показать двумерный массив размером m×n заполненный вещественными числами
Console.Clear();
double[,] ArrayDouble(double[,] array, int minValue, int maxValue)
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
void PrintArray(double[,] array)
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
int m = 2;
int n = 5;
double[,] Double = new double[m, n];
ArrayDouble(Double, 100000, 9999999 );
Console.WriteLine($"Двумерный массив вещественных чисел: m [{m}] x n [{n}]: ");
PrintArray(Double);
