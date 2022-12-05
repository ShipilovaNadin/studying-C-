// создаем массив и наполняем его 10 цыфрами подобранными случайно, потом выводим на печать массив

void FillArray(int[] collection)          // определяем тип метода как невозвратный (не нужна команда return)
{
    int length = collection.Length;   // определили длину массива и положили значение в имя length
    int index = 0;
    while (index < length)           // вводим цикл 
    {
        collection[index] = new Random().Next(1, 10); // берем аргумент из массива с индексом 0 и кладем туда рандомное число от 1 до 10
        index ++; // или можно записать как index = index+1 - переходим на следующий индекс пока не дойдем до последнего индекса в массиве 
    }
}

void PrintArray(int[] col)
{
    int count = col.Length; // получаем цифру со значением длины массива и закладываем ее в count
    int position = 0; // ввыдим переменную обозначающую порядковый номер элементов массива

    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[]collection, int find) // находим индекс элемента массива, совпадающего с заданным значением find
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // создали новый массив с именем array состоящий из 10 элементов

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 9);
Console.WriteLine(pos);
