// Задание 3. Написать программу копирования массива 
Console.Clear();
Console.WriteLine("Программа копирования массива:");

void CreateArray(int[] createArray,int min,int max)
{
	for (int i = 0; i < createArray.Length; i++)
	{
		createArray[i] = new Random().Next(min, max);
	}
}

void PrintArray(int[] printArray)
{
	Console.Write(printArray[0]);
	for (int i = 1; i < printArray.Length; i++)
	{
		Console.Write($", {printArray[i]}");
	}
	Console.WriteLine();
}

Console.Write("Введите длинну массива: ");
int length = int.Parse(Console.ReadLine());

int[] array = new int[length];
CreateArray(array, -100, 100);
Console.WriteLine("Первоначальный массив: ");
PrintArray(array);

int[] newArray = new int[array.Length];
for (int i = 0; i < array.Length; i++)
{
	newArray[i] = array[i];
}
Console.WriteLine("Копия массива: ");
PrintArray(newArray);