// Удалить вторую цифру трёхзначного числа
Console.WriteLine("Введите число от 100 до 999:");
int a = int.Parse(Console.ReadLine()?? "0");
if (a < 100 || a > 999)
{
    Console.WriteLine("Внимание! Число должно быть в диапазоне 100 - 999");
}
else
{
    a = a / 100 * 10 + a % 10;
    Console.WriteLine("Число без второй цифры " + a);
}
