// По двум заданным числам проверять является ли одно квадратом другого
Console.Write("Введите первое число:");
int a = int.Parse(Console.ReadLine()?? "0");
Console.Write("Введите второе число:");
int b = int.Parse(Console.ReadLine()?? "0");
if (a == b*b || b == a*a)
{
    Console.WriteLine("Заданные числа являются квадратом другого");
}
else 
{
    Console.WriteLine("Заданные числа не являются квадратом другого");
}

