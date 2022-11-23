// Задача 51: 
// Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив: 
// 1 47 2
// 5 92 3
// 8 42 4
// Сумма элементов главной диагонали: 1+9+2 = 12

 

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} | ");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}

int FindSumDiagonal(int[,] matrix)
{
    int sum = default;
    for (int i = 0; i < matrix.GetLength(0) && i<matrix.GetLength(1); i++)
    {
        
            sum += matrix[i,i];
    }
    return sum;
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
int result = FindSumDiagonal(array2D);
Console.WriteLine($"суммa элементов, находящихся на главной диагонали = {result}");