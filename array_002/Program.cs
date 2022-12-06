// заполняем и выводим на печать двумерный массив

void PrintArray(int[,] matr) //задаем функцию переменной которой двумерный массив матр
{
    for (int i = 0; i< matr.GetLength(0); i++)  // первый цикл проходится по строкам ->(0)
    {
        for (int j = 0; j < matr.GetLength(1); j++) // второй цикл проходится по столбцам -> (1)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}

int [,] matrix = new int[3, 4];  // задаем новый массив с 3 строками и 4 столбцами

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);