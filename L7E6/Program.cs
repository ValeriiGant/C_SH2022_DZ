// Лекция 7. Рекурсия (7.6.22) Перебор слов
Console.Clear();
int n = 1;
void FindWords (string alphabit, char [] word, int len = 0)
{
    if (len==word.Length)
    {
        Console.WriteLine($"{n++} {new String (word)}"); return;
    }
    for (int i=0; i<alphabit.Length; i++)
    {
        word[len]=alphabit[i];
        FindWords(alphabit,word,len+1);
    }
}
FindWords("аисв", new char[5]);
