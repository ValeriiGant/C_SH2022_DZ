// Задание 2. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
Console.Clear();
int[] arr = new int[12];
int sumplus = 0;
int summinus = 0; 
for (int i = 0; i < arr.Length; i++) 
{
    arr[i] = new Random().Next(-9,10);
    Console.Write($"{arr[i]} ");
    if (arr[i]>0) sumplus=sumplus+arr[i];
    else if (arr[i]<0) summinus=summinus+arr[i];
}
Console.WriteLine();
Console.WriteLine ($"Сумма положительных Элементов массива = {sumplus}");
Console.WriteLine ($"Сумма отрицательных Элементов массива = {summinus}");