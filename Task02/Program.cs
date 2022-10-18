// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите номер: ");
int a = Convert.ToInt32(Console.ReadLine());


if (a > 0 && a < 8)
{
    if (a == 1) Console.Write("Понедельник");
    else if (a == 2) Console.Write("Вторник");
    else if (a == 3) Console.Write("Среда");
    else if (a == 4) Console.Write("Четверг");
    else if (a == 5) Console.Write("Пятница");
    else if (a == 6) Console.Write("Суббота");
    else (a == 7) Console.Write("Воскресение");
}


else Console.Write("Такого дня не существует");