// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
Console.Clear();
double[] arr = new double[10];
for (int i = 0; i < arr.Length; i++)
{
arr[i] = new Random().NextDouble()*10;
Console.WriteLine($"{arr[i]} ");
}
double max = arr[0];
double min = arr[0];

for (int i = 1; i < arr.Length; i++)
{
if(arr[i] < min) min = arr[i];
if(arr[i] > max) max = arr[i];
}
Console.WriteLine($"max = {max}");
Console.WriteLine($"min = {min}");

Console.WriteLine($"Разница = {max-min}");

//Console.Clear(); ///2 вариант
//float [] arr = {3.5f, 4.2f,355,4,5555};
//float max = arr[1];
//float min = arr[0];
//for(int i = 0; i < arr.Length; i++)
//{
//if(arr[i] > max)
//{
//max = arr[i];
//}
//if(arr[i]< min)
//{
//min = arr[i];
//}
//}
//Console.WriteLine(max-min);

//Console.Write("Введите размер массива: "); /// 3 вариант

//int Number = int.Parse(Console.ReadLine() ?? "0");
//double[] arr = new double[Number];

//for (int i = 0; i < Number; i++)
//{
//arr[i] = new Random().NextDouble() * 10;
//arr[i] = Math.Round(arr[i],2);
//Console.Write($"{arr[i]} ");
//}
//Console.WriteLine("");

//int min = 0;
//int max = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//if (arr[i] < arr[min]) min = i;
//else if (arr[i] > arr[max]) max = i;

//}

//Console.WriteLine($"Разница между {arr[max]} и {arr[min]} = {arr[max] - arr[min]}");