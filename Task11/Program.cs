// вывод случайного трехзначного числа и удаление второй цифры этого числа
// 456 - 46
// 782 - 72

int num = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из диапазона 1 - 1000 -> {num}");

int FirstLastNum(int number)
{
    int firstDigit = number / 100;
    int thirdDigit = number % 10;
    int result = firstDigit * 10 + thirdDigit;
    return result;
}

Console.WriteLine(FirstLastNum(num));