// Поиск второго максимума

Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int maxFirst = n, maxSecond = -1;
while(n!=0) // эта конструкция позволяет воодить натуральные числа, пока пользователь не введет 0. После цикл остановится
{
    n = Convert.ToInt32(Console.ReadLine());
    if (n > maxFirst)
    {
        maxSecond = maxFirst;
        maxFirst = n;
    }
    else if (n > maxSecond)
    maxSecond = n;
}
Console.WriteLine(maxSecond); // и покажет второе максимальное число из тех что были введены до 0
