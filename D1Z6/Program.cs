// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.WriteLine("Введите число от 10 до 99:");
int a = int.Parse(Console.ReadLine()?? "0");
int a1 = a / 10;
int a2 = a % 10;
if(a1 > a2) Console.Write(a1);
else Console.Write(a2);
