// Задание 3. Написать программу, которая в двумерном массиве заменяет строки на столбцы 
//или сообщить, что это невозможно (в случае, если матрица не квадратная).
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

void ChangeRowColumn(int[,] array) 
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j > i)
                {
                    int tmp = array[i, j];
                    array[i, j] = array[j, i];
                    array[j, i] = tmp;
                }
            }
        }
    }
    else
        {
            Console.WriteLine("Матрица не квадратная");
            Console.WriteLine();
        }
}

Console.Write("Введите количество строк = ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов = ");
int b = int.Parse(Console.ReadLine() ?? "0");

int[,] array = new int[a, b];
for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(1, 10);

PrintArray(array);

ChangeRowColumn(array);
PrintArray(array);
