// Найти третью цифру числа или сообщить, что её нет
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine()?? "0");
int b = a, count = 0;
while (b > 0) 
{
    b = b / 10;
    count++;  
}

int n = 3;
if (count >= 3)
{
    while (n < count) 
    {
        a = a / 10;
        n++;

    }
    a = a % 10; 
    Console.WriteLine("Третья цифра числа а: " + a);
}
else Console.WriteLine("Число а имеет меньше трех знаков, поэтому сообщаем, её нет!");




