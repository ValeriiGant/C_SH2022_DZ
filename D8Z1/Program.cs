//Задание 1. Найти произведение двух матриц
Console.Clear();
void PrintArray(int[,] arrayforprint)   
{
    for (int i = 0; i < arrayforprint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayforprint.GetLength(1); j++)
        {
            Console.Write($"{arrayforprint[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int FMultIJ(int[,] array0, int[,] array1, int iO, int jO) 
{
    int result = 0;
    for (int i = 0; i < array0.GetLength(1); i++)
    {
        result += array0[iO, i] * array1[i, jO];
    }
    return result;
}


int[,] MultipleArray(int[,] array0, int[,] array1)  
{
    int[,] multiplArray = new int[array0.GetLength(0), array1.GetLength(1)];
    if (array0.GetLength(1) == array1.GetLength(0))
    {
        for (int i = 0; i < multiplArray.GetLength(0); i++)
        {

            for (int j = 0; j < multiplArray.GetLength(1); j++)
            {
                multiplArray[i, j] = FMultIJ(array0, array1, i, j);
            }
        }
    }
    else Console.WriteLine("Введите равное число строк и столбцов матриц!");
    return multiplArray;
}

Console.Write("Введите число строк матрицы #1 = ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов матрицы #1 = ");
int b = int.Parse(Console.ReadLine() ?? "0");

int[,] array0 = new int[a, b];
for (int i = 0; i < array0.GetLength(0); i++)
    for (int j = 0; j < array0.GetLength(1); j++) array0[i, j] = new Random().Next(1, 10);


Console.Write("Введите число строк матрицы #2 = ");
int a1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов матрицы #2 = ");
int b1 = int.Parse(Console.ReadLine() ?? "0");

int[,] array1 = new int[a1, b1];
for (int i = 0; i < array1.GetLength(0); i++)
    for (int j = 0; j < array1.GetLength(1); j++) array1[i, j] = new Random().Next(1, 10);

Console.WriteLine($"Матрица #1:  ");
PrintArray(array0);
Console.WriteLine($"Матрица #2:  ");
PrintArray(array1);

int[,] newArr = MultipleArray(array0, array1);
Console.WriteLine($"Произведение двух матриц:  ");
PrintArray(newArr);
