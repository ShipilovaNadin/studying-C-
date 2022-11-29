// отрабатываем цикл for

string Method4(int count, string text);
{   
    string result = string.Empty; // мы вводим строчку куда будет вноситься результат и пока она пустая. Так это можно записать красиво
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);