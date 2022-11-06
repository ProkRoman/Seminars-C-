//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Table (int n)
{
    if (n > 0)
    {
        int index = 1;
        while (index <= n)
        {
            Console.WriteLine($"{index, 4} {index*index*index, 4}" );
            index++;
        }
    }
    else Console.WriteLine("Некорректное число");
}

Console.WriteLine("Введите число N ");
int n = Convert.ToInt32(Console.ReadLine());

Table(n);