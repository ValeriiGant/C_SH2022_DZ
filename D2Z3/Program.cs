// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите номер четверти");
string number = Console.ReadLine()?? "0";
if (number == "1") Console.WriteLine($"Для {number} четверти коордитаты x>0, y>0");
else if (number == "2") Console.WriteLine("Для {number} четверти коордитаты x<0, y>0");
else if (number == "3") Console.WriteLine("Для {number} четверти коордитаты x<0, y<0");
else if (number == "4") Console.WriteLine("Для {number} четверти коордитаты x>0, y<0");
else Console.WriteLine("Нет такой четверти");