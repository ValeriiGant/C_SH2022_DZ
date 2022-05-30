// Задание 2. Найти кубы чисел от 1 до N
Console.Clear();
Console.Write("\n" + "Возведем в куб числа от 1 до: ");
int digit = int.Parse(Console.ReadLine()?? "");
Console.WriteLine($"\n" + $"Кубические выражения чисел от 1 до {digit}:\n");

for (int i = 0; i <= digit; i++)
{
    Console.WriteLine($"от {i} кубическое число = {i*i*i}");
}
