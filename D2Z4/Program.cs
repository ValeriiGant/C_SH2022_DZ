// Найти расстояние между точками в пространстве 2D/3D
Console.Clear();
Console.Write("Введите систему координат-индекс каждого массива(>1):");
int S = int.Parse(Console.ReadLine()?? "0");
double[] point1 = new double[S];                ///задаем размер первого массива для координат первой точки
double[] point2 = new double[S];                ///задаем размер второго массива для координат второй точки
double L = 0;                                   ///определяем расстояния между точками
for (int i = 0; i < S; i++)                    /// инициализируем размеры массивов для координат точек
{
    Console.Write("Введите {i + 1} координату для первой точки ");
    point1[i] = double.Parse(Console.ReadLine());
    Console.Write("Введите {i + 1} координату для второй точки ");
    point2[i] = double.Parse(Console.ReadLine());
    L += (point1[i] - point2[i]) * (point1[i] - point2[i]);
}
Console.WriteLine("Координаты первой точки ({0})", String.Join("; ", point1));
Console.WriteLine("Координаты второй точки ({0})", String.Join("; ", point2));
Console.WriteLine("Расстояние между точками = " + Math.Sqrt(L));
