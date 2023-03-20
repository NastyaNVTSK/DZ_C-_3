Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
int res = 1;
for (int i = 0; i < num2; i++)
{
    res *= num1;
} 

Console.WriteLine($"Результат возведения числа равен: {res}");