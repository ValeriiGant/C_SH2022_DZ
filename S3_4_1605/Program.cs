//Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число n:");
int n = int.Parse(Console.ReadLine()?? "0");
int p = 1;
for (int i=1; i<= n; i++)
{
    p=p*i;
}
Console.WriteLine($"Произведение чисел от 1 до {n}={p}");
