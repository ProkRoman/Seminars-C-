// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа. Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SecondNum(int number)
{
    int secondDigit =(number / 10) % 10;
    return secondDigit;
}

Console.WriteLine(SecondNum(num));