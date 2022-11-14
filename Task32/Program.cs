// Задача 32:
// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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
        if (i < Array.MaxLength - 1) Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
}

void MirrorArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
}

int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);


MirrorArray(arr);

Console.WriteLine($"Замена элементов массива с противоположным знаком.");
PrintArray(arr);