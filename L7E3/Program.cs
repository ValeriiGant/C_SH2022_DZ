// Лекция 7. Рекурсия (7.6.22) Сумма чисел от 1 до n
Console.Clear ();
int SumFor (int n)
{
    int result = 0;
    for (int i=1; i<=n; i++) result +=i;
    return result;
}
int SumRec (int n)
{
    if (n==0) return 0;
    else return n + SumRec (n-1);
}
Console.WriteLine (SumFor(10));
Console.WriteLine (SumRec(10));

