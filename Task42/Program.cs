// Задача 42: 
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101 
// 3 -> 11
// 2 -> 10

Console.WriteLine("введите число ");
int number = Convert.ToInt32(Console.ReadLine());

string DecToBin(int num)
{
    string result = "";
    while (num > 0)
    {
        result = $"{num % 2}{result}";
        num = num/2;
    }
    return result;
}

Console.WriteLine(DecToBin(number));