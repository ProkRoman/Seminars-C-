// 12 программа которая принимает на 
//вход два числа и выводить является ли 
//первое число кратным второмую. Если число 1
// не кратно числу 2, то программа выводит остаток от деления
// 34, 5 - не кратно, остаток 4
// 16, 4 - кратно

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

// bool Multiple(int number1, int number2)
// {
//     return number1 % number2 == 0;
// }

// bool multiple = Multiple(num1, num2);
//Console.WriteLine(mulple ? "Кратно" : $"не кратно, остаток {number1 % number2}");

int Multiple(int number1, int number2)
{
    return number1 % number2;
}

int rest = Multiple(num1,num2);
Console.WriteLine(rest ==0 ? "Кратно" : $"не кратно, остаток {rest}");