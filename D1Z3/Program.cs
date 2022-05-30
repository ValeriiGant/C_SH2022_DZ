// Выяснить является ли число чётным
Console.Write("Input digital:");
int a = int.Parse(Console.ReadLine()?? "0");

if (a % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else 
{
    Console.WriteLine("Число не четное");
}