// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int DifElements(int[] array, int min1, int max1)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min1)
        {
            min1 =array[i];
        }
        if (array[i] > max1)
        {
            max1 = array[i];
        }  
        
    }
    return sum;
}

int[] arr = CreateArrayRndInt(5, 1, 99);
PrintArray(arr);

int difElements = DifElements(arr);
Console.WriteLine($"сумма элементов, стоящих на нечётных позициях = {difElements}");
PrintArray(arr);