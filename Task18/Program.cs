﻿// Напишите программу которая по заданному номеру четверти 
// показывает диапазон возможных координат (x,y)


Console.WriteLine("Введите номер четверти ");
int num = Convert.ToInt32(Console.ReadLine());


string Quarter(int number)
{
    if (number == 1) return "x > 0 и y > 0";
    if (number == 2) return "x < 0 и y > 0";
    if (number == 3) return "x < 0 и y < 0";
    if (number == 4) return "x > 0 и y < 0";
    return "Некорректный ввод";
}

string quarter = Quarter(num);

Console.WriteLine($"Диапазон:{quarter}");
