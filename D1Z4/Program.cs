// Показать четные числа от 1 до N
Console.Write("Введите число :");
int n = int.Parse(Console.ReadLine()?? "0");
int count = 2;
Console.WriteLine($"Четные числа от 1 до {n}:");
while (count <= n)
{
    Console.Write(count + " ");
    count += 2;
}