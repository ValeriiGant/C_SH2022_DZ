// Лекция 7. Рекурсия (7.6.22) Собрать строку с числами от а до b, a>=b
Console.Clear ();
string NumbersFor (int a, int b)
{
    string result = String.Empty;
    for (int i = a; i>= b; i--)
    {
        result += $"{i}";
    }
    return result;
}

string NumbersRec (int a, int b)
{
      if (a <= b) return NumbersRec(a + 1, b) + $" {a} ";
      else return String.Empty;
}
Console.WriteLine (NumbersFor (1, 10));
Console.WriteLine (NumbersRec (1, 10));
