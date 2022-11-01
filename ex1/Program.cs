// Определение мин и макс, Печать массива на экран, Поиск суммы элементов массива,Поиск произведения элементов массива
//Среднее арифметическое элеметов массива, Подсчёт количества отрицательных элементов массива,Подсчёт количества положительных элементов в массиве
//Подсчёт количества чётных элементов в массив, Подсчёт количества нечётных элементов в массиве
//Поиск индекса заданного элемента в массиве, если такого элемента в массиве нет то возвращать -1
//Подсчёт количества вхождений элемента в массив


int[] array = { 7, 3, 6, 9, 1, 5, 5, 2 };
int min = int.MaxValue;
int max = int.MinValue;
int sum = 0;
int comp = 1;
int arithmeticmean = 0;
int num = 0;
int num1 = 0;
int num2 = 0;
int num3 = 0;
int x = new Random() .Next(1,10);
int num4 = 0;
int num5 = 0;
void Printarray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
        sum = sum + array[i];
        comp = comp * array[i];
        arithmeticmean = sum / array.Length;
        if (array[i] == x)
        {
            num4 = num4 + 1;
            num5 = i;
        }
        else
        {
            Console.Write ($"индекс заданного элемента в массиве{-1}");
        }
        if (array[i] % 2 == 0 && array[i] != 0)
        {
            num2 = num2 + 1;
        }
        if (array[i] % 2 != 0 && array[i] != 0)
        {
            num3 = num3 + 1;
        }
        if (array[i] < 0)
        {
            num1 = num1 + 1;
        }
        if (array[i] > 0)
        {
            num = num + 1;
        }
        if (min > array[i])
        {
            min = array[i];
        }
        else
            if (max < array[i])
        {
            max = array[i];
        }
       
    }
}
Printarray(array);  // вывод массива
Console.WriteLine($"min {min} max {max} sum {sum} comp {comp} arithmeticmean {arithmeticmean} количествo положительных элементов {num} количествo отрицательных элементов {num1} количества чётных элементов {num2}");
Console.WriteLine($"количествo нечётных элементов в массиве {num3} количествo вхождений элемента {x} в массив {num4} поиск индекса заданного элемента {x} в массиве {num5}");
