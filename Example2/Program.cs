Console.Clear();

Console.Write("Введите любое число ");
int number = int.Parse(Console.ReadLine());
int length = NumberLength(number);

SumNumbers(number, length);


int NumberLength(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void SumNumbers(int n, int length)
{
    int sum = 0;
    for (int i = 1; i <= length; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($"сумма цифр {sum}");
}