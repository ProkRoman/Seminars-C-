//9. 
//- вывод случайного числа из отрезка [10,99] и 
//- показывает наибольшую цифру числа

//78 - 8
//85 - 8

int num = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из диапазона 10 - 99 -> {num}");

// int firstDigit = num / 10; // 78 / 10 = 7
// int secondDigit = num % 10; // 78 % 10 = 8

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа = {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа {num} = {secondDigit}");

// int result = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа {num} = {result}");


// int max = Math.Max(firstDigit, secondDigit);
// Console.WriteLine($"Наибольшая цифра числа {num} = {max}");

int MaxDigit(int num)
{
    int firstDigit = num / 10; // 78 / 10 = 7
    int secondDigit = num % 10; // 78 % 10 = 8
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit  = MaxDigit(num);
Console.WriteLine($"Наибольшая цифра числа {num} = {maxDigit}");