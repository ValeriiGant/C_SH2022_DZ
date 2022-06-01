// Семинар 5. Задание 2. Написать программу преобразования десятичного числа в двоичное
Console.Clear();
Console.Write("Введите десятичное число:");
int a = int.Parse(Console.ReadLine() ?? "0");
int b = 0;
string result = " ";
//int result = 0;

while(a > 0)
{
b = a % 2;
result = b + result;
a = a / 2;

}
Console.WriteLine($"Двоичное число = {result}");

//ВАРИАНТ 3.
//Console.Write("Введите число: ");
//int Number = int.Parse(Console.ReadLine() ?? "0");
//int Bit = Number % 2;
//int NewNumber = Bit;
//Number = Number / 2;
//int i = 1;
//while (Number > 0)
//{
//Bit = Number % 2;
//Number = Number / 2;
//NewNumber = NewNumber + Bit * (int)Math.Pow(10,i);
//i++;
//}
//Console.WriteLine(NewNumber);