// S10Z1 ~ Семинар 10. ~ 9.06.2022:Найти сумму цифр числа 
Console.Clear ();
uint SumDigits(uint n) => n<10 ? n : n%10 + SumDigits(n/10);
Console.Write("Enter your number: ");
uint n = uint.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Sum of digits {SumDigits(n)}");

