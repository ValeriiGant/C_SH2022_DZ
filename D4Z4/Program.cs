// Задание 4. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
Console.Clear();
int[] arr = new int[123];
int digits = 0;
for (int i = 0; i < arr.Length; i++) 
{
    arr[i] = new Random().Next(10,99);
    Console.Write($"{arr[i]} ");
    if (arr[i]>=10 && arr[i]<=99) digits++;
}
Console.WriteLine();
Console.WriteLine ($"Количество Элементов из отрезка [10,99] = {digits}");
