// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());



int ThirdNum(int number)
{
    int thirdDigit = number % 10;
    return thirdDigit;
}
int rest = ThirdNum(num);

if (num > 100) Console.WriteLine(rest);
else Console.WriteLine("третьей цифры нет");
