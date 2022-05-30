// Показать таблицу квадратов чисел от 1 до N
//Console.Write("Введите число:");
//int n = int.Parse(Console.ReadLine()?? "0");
//int count = 0;
//while(count < 0)
//{
  // int digit=count+1
  //  Console.WriteLine($"Список квадратов чисел от 1 до {n}(digit*digit)");
  //  count++;
//}

Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine()?? "0);
for (int i = 1; i <=n; i++)
{
    Console.Write($"{i * i} ");
}
