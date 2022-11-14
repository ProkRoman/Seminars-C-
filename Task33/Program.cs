﻿// Задача 33:
//  Задайте массив. Напишите программу, которая определяет, 
//  присутствует ли заданное число в массиве.
//  4; массив [6, 7, 19, 345, 3] -> нет 
//  3; массив [6, 7, 19, 345, 3] -> да
 
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

bool FindNumberArray(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) return true; 
    }
    return false;
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArrayRndInt(12, -6, 7);
PrintArray(arr);
bool result = FindNumberArray(arr, num);


Console.WriteLine(result ? "Да" : "Нет");
