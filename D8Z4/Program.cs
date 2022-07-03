// Задание 4. Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
Console.Clear();
void PrintArrayStr(string[,] arraynew)   
{
    for (int i = 0; i < arraynew.GetLength(0); i++)
    {
        for (int j = 0; j < arraynew.GetLength(1); j++)
        {
            Console.Write(arraynew[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillArray(int[,] array)  
{
    array[0, array.GetLength(1) / 2] = 1;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) array[i, j] = array[i - 1, j + 1];
            else if (j == array.GetLength(1) - 1) array[i, j] = array[i - 1, j - 1];
            else array[i, j] = array[i - 1, j - 1] + array[i - 1, j + 1];
        }
    }
}

string[,] IntToStringArray(int[,] array) 
{
    string[,] strarray = new string[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == 0) strarray[i, j] = " ";
            else strarray[i, j] = array[i, j].ToString();
        }
    }
    return strarray;
}

Console.Write("Введите высоту треугольника = ");
int a = int.Parse(Console.ReadLine() ?? "0");
int b = a * 2 - 1;
int[,] array = new int[a, b];

FillArray(array);

string[,] stringArray = IntToStringArray(array);
PrintArrayStr(stringArray);
