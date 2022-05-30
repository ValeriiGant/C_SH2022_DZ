// Задание 5. Подсчитать сумму цифр в числе
Console.Clear();
Console.Write("Введите число: ");
int digit = int.Parse(Console.ReadLine()?? "");
int count = 0;
int result = digit;
while (result != 0)
{
    count += result % 10;
    result = result / 10;
}
Console.WriteLine($"Сумма чисел в составе числа: {digit} = {count}");