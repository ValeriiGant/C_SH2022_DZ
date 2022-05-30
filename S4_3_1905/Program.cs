// Найти сумму чисел одномерного массива стоящих на нечетной позиции
Console.Clear();
int[] arr = new int[8];
for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(1, 10);
int sum = 0;
for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]} ");
Console.WriteLine();
for (int i = 0; i < arr.Length; i = i + 2)
{
sum = sum + arr[i];
}
Console.WriteLine($"Сумма нечетных элементов массива равна {sum}");

//Console.Clear(); /// 2 вариант
//Console.WriteLine("");
//int[] array = {12, 14, 5, 2, 6, 10};
//int result = 0;
//int length = array.Length;
//for (int i = 0; i < length; i++)
//{
//if (i % 2 != 0)
//{
//result = result + array[i];
//}
//}
//Console.WriteLine(result);