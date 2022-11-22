// Ищем максимум из 9 чисел используя массив данных

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//               0 1    2   3   4   5   6   7   8
int[] array = { 90, 23, 63, 14, 24, 56, 72, 42, 60 };

int result = Max(
    Max(array, b1, c1), 
    Max(а2, b2, c2), 
    Max(a3, b3, c3));
Console.WriteLine(result);
