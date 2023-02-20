// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Веести пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);
int number1 = 0;
int number2 = 0;
int number3 = 0;
int number4 = 0;

if (number >= 100000 || number < 10000)
{
    Console.WriteLine("Ведите число 10000 до 99999");
}

else if (number < 99999)
{
    number1 = number / 10000;
    number2 = number % 10;
    number3 = number / 1000 % 10;
    number4 = number % 100 / 10;

    if (number1 == number2 || number3 == number4)
    {
        Console.Write("Да");
    }
    else
    {
        Console.Write("Нет");
    }
}
