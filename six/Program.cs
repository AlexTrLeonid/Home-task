Console.WriteLine("Введите число : ");
int N = int.Parse(Console.ReadLine()!);
int sum = 0;
while (N > 0)
{
    sum += N % 10;
    sum += N / 10;
    sum += N;
}
Console.WriteLine("Сумма всех цифр этого числа = ", sum);
