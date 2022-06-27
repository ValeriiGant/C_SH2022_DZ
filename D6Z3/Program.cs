// Задание 3. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
Console.Clear();
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ReplaceArray(int[,] arr)    ///метод замены элементов массива на их квадраты, если оба индекса четные
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) arr[i,j] *= arr[i,j];
        }
        Console.WriteLine();
    }
}
Console.Write("Введите количество строк a = ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов b = ");
int b = int.Parse(Console.ReadLine() ?? "0");
int[,] arrayNew = new int[a, b];
for (int i = 0; i < a; i++)
{
    for (int j = 0; j < b; j++)
    {
        arrayNew[i, j] = new Random().Next(1,10);
    }
}

PrintArray(arrayNew);

ReplaceArray(arrayNew);
PrintArray(arrayNew);
