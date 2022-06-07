// Лекция 7. Рекурсия (7.6.22) Состав Каталога/директории (папки) и состав файлов папки
Console.Clear();
void CatalogInfo (string path, string indent ="")
{
    DirectoryInfo catalog = new DirectoryInfo(path);
    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i=0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs [i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }
    FileInfo[] files = catalog.GetFiles();
    for (int i=0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}
string path = @"C:/Users/4vpos/C_SH2022_DZ";
CatalogInfo(path);