﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]m);
Console.Clear();
int[] FillArray()
{
    int[] array = new int[8];
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(1, 9);
        index++;
    }
    return array;
}
void PrintArray(int[] number)
{
    int length = number.Length;
    int index = 0;
    Console.Write("[");
    while (index < length)
    {
        Console.Write(number[index]);
        if (index != length - 1)
        {
            Console.Write(", ");
        }
        index++;
    }
    Console.Write("]");
}
void IfPrintArray(int[] number)
{
    int length = number.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write(number[index]);
        if (index != length - 1)
        {
            Console.Write(", ");
        }
        index++;
    }
}

int[] array = FillArray();
IfPrintArray(array);
Console.Write(" -> ");
PrintArray(array);