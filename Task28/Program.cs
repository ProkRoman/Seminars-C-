// Задача 28: Напишите программу, 
// которая принимает на вход число N и 
// выдаёт произведение чисел от 1 до N.
 
// 4 -> 24 
// 5 -> 120


Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int Factorial(int num)
{
    int com = 1;
    for (int i = 1; i <= num; i++)
    {
        com *=i; // sum = sum + 1
    }
    return com ;
}

int factorial = Factorial(a);
Console.WriteLine($"Произведение чисел от 1 до {a} = {factorial}");