// Проверка наличия элемента в массиве. Возвращает true, если элемент в массиве есть, false – нет.
//Проверка является ли массив отсортированным по возрастанию. Если массив отсортирован, то возвращать true, иначе - false.

int[] array = { 7, 3, 6, 9, 1, 5, 5, 2 };
int x = new Random().Next(1, 10);
bool TrueArray(int[] array, int x)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == x)
            return true;
    return false;
}
bool y = TrueArray (array, x);
Console.WriteLine($"число {x},{y}");


bool SortArray(int[] array)
{
   for (int i = 0; i < array.Length - 1; i++)
        if (array[i] > array[i + 1])
            return false;
    return true; 
}
bool a = SortArray(array);
Console.WriteLine($"массив является отсортированным по возрастанию {a}");