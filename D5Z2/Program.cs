// Задание 2. Написать программу масштабирования фигуры 
// Тут для тех, кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
Console.Clear();
int[,] FillArray2(int x, int y)
{
    int[,] array = new int[x, y];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 4);
        }
    }
    return array;
}

void PrintArray2(int[,] tabl)
{
    for (int i = 0; i < tabl.GetLength(0); i++)
    {
        for (int j = 0; j < tabl.GetLength(1); j++)
        {
            Console.Write($"{tabl[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Scale(int[,] array, int k)
{
    string result = string.Empty;
    int[,] array2 = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array2[i, j] = array[i, j] * k;
            Console.Write($"{array2[i, j]} ");
        }
        Console.WriteLine();
    }

}

int[,] newarray = FillArray2(4, 2);
PrintArray2(newarray);
Console.WriteLine();
Scale(newarray, 2);