// Задание 1. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

Console.Clear();
int[] arr = new int[8];
for (int i = 0; i < arr.Length; i++) 
{
    arr[i] = new Random().Next(0,2);
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();
