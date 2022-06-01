// Задание 3. Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел
Console.Clear();
int[] arr = new int[10];
int chet = 0;
int nechet = 0; 
for (int i = 0; i < arr.Length; i++) 
{
    arr[i] = new Random().Next(100,1000);
    Console.Write($"{arr[i]} ");
    if (arr[i]%2==0) chet++;
    else nechet++;
}
Console.WriteLine();
Console.WriteLine ($"Количество четных чисел = {chet}");
Console.WriteLine ($"Количество нечетных чисел = {nechet}");
