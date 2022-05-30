// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.Write("Введите число a ");
int a = int.Parse(Console.ReadLine()?? "0");
Console.Write("Введите число b ");
int b = int.Parse(Console.ReadLine()?? "0");
if (a < b)
{
    if (b % a == 0) Console.Write("Число b кратно a");
    else Console.Write("Число b не кратно a, так как имеет остаток " + b % a);
}
else
{
    if (a % b == 0) Console.Write("Число a кратно b");
    else Console.Write("Число a не кратно b, так как имеет остаток " + a % b);
}