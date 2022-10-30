// Напишите программу которая принимает на вход число 
// (N) и выдает таблцу квадратов чисел от 1 до N

// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4


void Table (int n)
{
    if (n > 0)
    {
        int index = 1;
        while (index <= n)
        {
            Console.WriteLine($"{index} {index*index}" );
            index++;
        }
    }
    else Console.WriteLine("Некорректное число");
}

Console.WriteLine("Введите число N ");
int n = Convert.ToInt32(Console.ReadLine());

Table(n);

