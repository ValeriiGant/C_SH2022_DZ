// Лекция 7. Рекурсия (7.6.22) Дата создания директории (папки) и состав файлов папки
Console.Clear();
string path = "C:/Users/4vpos/C_SH2022_DZ/D1Z1";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo [] fi = di.GetFiles();
for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}