// Задание 5. Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Console.Clear();
int a = 50;
int[] arr = new int[a];
for (int i = 0; i < arr.Length; i++) 
{
    arr[i] = new Random().Next(0,50);
    Console.Write(arr[i]+ " ");
}
Console.WriteLine();
int b = arr.Length - 1;
for (int i=0; i<(arr.Length+1)/2;i++)
{
    Console.Write(arr[i]*arr[b]+ " ");
    b--;
}
