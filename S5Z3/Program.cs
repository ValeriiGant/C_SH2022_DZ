// Семинар 5. Задание 3. Показать числа Фибоначчи меньше заданного числа N
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()?? "");
int firstValue = 0;
int secondValue = 1;
int result = 0;
Console.Write($"{firstValue} {secondValue} ");
while(firstValue + secondValue < N)
{
result = firstValue + secondValue;
Console.Write(result + " ");
firstValue = secondValue;
secondValue = result;
}