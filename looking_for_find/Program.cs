// Ищем в массиве данных елемент find

int [] array = { 1, 12, 31, 4, 1, 15, 16, 17, 18 };

int n = array.Length;
int find = 1;

int index = 0;

while (index < n)
{

    if(array[index] == find)    // это значит эквивалент левой части и правой
    {
        Console.WriteLine(index);
        break;
    }
    index++; // index = index + 1;
}
