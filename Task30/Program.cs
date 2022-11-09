// Задача 30: 
// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.

//  [1,0,1,1,0,1,0,0]



void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]= new Random().Next(0,2);
        if (i!=arr.Length -1)Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]},");
    }
    Console.Write("]");
}

int [] array = new int[8];
PrintArray(array);