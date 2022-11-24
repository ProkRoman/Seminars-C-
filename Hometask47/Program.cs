// Задача 47. 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



void MatrixD(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j], 5} | ");
            else Console.Write($"{matr[i, j], 5}");
        }
        Console.WriteLine(" |");
    }
}

Console.WriteLine("Введите количество строк массива: m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк массива: n = ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[m, n];
MatrixD(numbers);
PrintMatrix(numbers);
