// Задание 3. Найти сумму чисел от 1 до А
Console.Clear();
Console.Write("\n" + "Введите число: ");
int digit = int.Parse(Console.ReadLine()?? "");
int sum = 0;
for (int i = 1; i <= digit; i++)
{
    sum+=i;
}
Console.WriteLine($"Сумма чисел от 1 до {digit} = {sum}");