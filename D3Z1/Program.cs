// Задание 1. Показать таблицу квадратов чисел от 1 до N
Console.Clear();
Console.Write("\n" + "Возведем в квадрат числа от 1 до: ");
int digit = int.Parse(Console.ReadLine()?? "");
Console.WriteLine($"\n" + $"Таблица квадратов от 1 до {digit}:\n");

for (int i = 0; i <= digit; i++)
{
    Console.WriteLine($"от {i} квадрат числа {i*i}");
}
