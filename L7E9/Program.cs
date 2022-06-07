// Лекция 7. Рекурсия (7.6.22) Перекладывание "блинчиков" с одной пирамидки на третью
Console.Clear();
void Towers(string with = "1", string on = "3", string some = "2", int count =3) 
// with - рабочий шпиль, on - шпиль где должны оказаться блины, 
// some - вспомогательный шпиль, count - кол-во блинов.
{
    if (count>1) Towers(with, some, on, count-1);
    Console.WriteLine($"{with}>> {on}");
    if (count>1) Towers(some, on, with, count -1);
}
Towers();
