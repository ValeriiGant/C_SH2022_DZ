// Задание 4. В прямоугольной матрице найти строку с наименьшей суммой элементов.
Console.Clear();
void PrintArray(int[,] arraynew)   
{
    for (int i = 0; i < arraynew.GetLength(0); i++)
    {
        for (int j = 0; j < arraynew.GetLength(1); j++)
        {
            Console.Write($"{arraynew[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void LeastRow(int[,] array)  
{
    int LeastIndex = 0;
    int[] Plus = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Plus[i] += array[i, j];
        }
        if (Plus[i] < Plus[LeastIndex]) LeastIndex = i;
    }     
    Console.WriteLine($"Least plus row Наименьшая сумма элементов строк= {Plus[LeastIndex]}, номер строки {LeastIndex}");
}

Console.Write("Введите количество строк = ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов = ");
int b = int.Parse(Console.ReadLine() ?? "0");

int[,] array = new int[a, b];
for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(1, 10);

PrintArray(array);
LeastRow(array);
