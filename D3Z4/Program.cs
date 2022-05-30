// Задание 4. Возведите число А в натуральную степень B используя цикл
Console.Clear();
Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine()?? "");
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine()?? "");
int result = a;
if (b <= 0) Console.WriteLine($"Число B не является натуральным!");
else
{
    for (int i = 2; i <= b; i++) result = result * a;
Console.WriteLine($"Возведенное число {a} в степень {b} = {result}");
}