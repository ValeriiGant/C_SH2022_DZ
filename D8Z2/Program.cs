//Задание 2. В двумерном массиве целых чисел. 
//Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
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

int[,] DelRowColumn(int[,] array)  //удаляем
{
    int LowIndex = 0; int Lowj = 0;
    for (int i = 0; i < array.GetLength(0); i++)   //индекс наименьшего элемента
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[LowIndex, Lowj])
            {
                LowIndex = i;
                Lowj = j;
            }
        }
    }
    int[,] DelArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1]; //исключаем требуемое
    for (int i = 0; i < array.GetLength(0); i++)  
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i < LowIndex && j < Lowj) DelArray[i, j] = array[i, j];
            if (i < LowIndex && j > Lowj) DelArray[i, j - 1] = array[i, j];
            if (i > LowIndex && j < Lowj) DelArray[i - 1, j] = array[i, j];
            if (i > LowIndex && j > Lowj) DelArray[i - 1, j - 1] = array[i, j];
        }
    }
    return DelArray;
}

Console.Write("Введите количество строк = ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов = ");
int b = int.Parse(Console.ReadLine() ?? "0");

int[,] array = new int[a, b];
for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(1, 10);


PrintArray(array);


int[,] newArr = DelRowColumn(array);
PrintArray(newArr);