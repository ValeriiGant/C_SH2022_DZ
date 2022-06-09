// S10Z2 ~ Семинар 10. ~ 9.06.2022: Написать программу возведения числа А в целую стень B
Console.Clear ();
//int NumberPower(int a, int b)
//{
    //if (b == 1) return a;
    //else return a * NumberPower(a, b-1);
//}
//Console.WriteLine (NumberPower(2,7));

//int PowerRecMath(int a, int n)
//{
   // if (n==0) return 1;
  //  else if (n % 2==0) return PowerRecMath (a * a, n / 2);
  //  return PowerRecMath (a, n-1) * a;
//}
//Console.Write(PowerRecMath(5,3));

//Var.2
double Amount(int a, int b) => b==1 ? a:a*Amount(a,b-1);
Console.Write("Введите число, для возведения в степень:");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите степень:");
int b = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine (Amount(a,b));
