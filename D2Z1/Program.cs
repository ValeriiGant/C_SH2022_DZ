// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите число дня недели:");
int weekday = int.Parse(Console.ReadLine()?? "0");
if (weekday == 1) Console.WriteLine ("Понедельник/Рабочий день");
else if (weekday == 2) Console.WriteLine ("Вторник/Рабочий день"); 
else if (weekday == 3) Console.WriteLine ("Среда/Рабочий день"); 
else if (weekday == 4) Console.WriteLine ("Четверг/Рабочий день"); 
else if (weekday == 5) Console.WriteLine ("Пятница/Рабочий день"); 
else if (weekday == 6) Console.WriteLine ("Суббота/Выходной день");
else if (weekday == 7) Console.WriteLine ("Воскресенье/Выходной день");
else Console.WriteLine("Извините, такого числа дня недели не существует! ");
