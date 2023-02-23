// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
Console.WriteLine("Введите число A: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int numberB = int.Parse(Console.ReadLine()!);
ToDegree(numberA, numberB);
void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}