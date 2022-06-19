// Вывести произведение чисел от 1 до N.

int Func(int N)
{
    int multiplication = 1;
    for (int i = 1; i <= N ; i++)
    {
        multiplication *= i;
    }
    return multiplication;
}

Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());

if (N <= 0)
{
    Console.WriteLine("Введите положительное число");
}
else
{
    Console.WriteLine(Func(N));
}