// Задание 6. Показать кубы чисел, заканчивающихся на четную цифру
Console.Clear();
Console.Write($"Введите число: ");
int d = int.Parse(Console.ReadLine()?? "");
if (d % 2 == 0) Console.WriteLine($"Возводим в куб число: {d} = {d* d * d}");
else Console.WriteLine($"Число: {d} не заканчивается на четную цифру!");