Console.Clear();

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень");
int b = int.Parse(Console.ReadLine());
Method1(a, b);

void Method1(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine($"{a} в степени {b} = {result}");
}