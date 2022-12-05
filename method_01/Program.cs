// отрабатываем цикл for

string Method4(int count, string text)
{   
    string result = String.Empty; // мы вводим строчку куда будет вноситься результат и пока она пустая. Так это можно записать красиво
    for( int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

Console.WriteLine(Method4(10,"Z"));