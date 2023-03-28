//Напишите программу, которая принимает на вход три числа и выдаёт максимальное

Console.WriteLine("ВВЕДИТЕ ПЕРВОЕ ЧИСЛО:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("ВВЕДИТЕ ВТОРОЕ ЧИСЛО:");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("ВВЕДИТЕ ТРЕТЬЕ ЧИСЛО:");
int c = int.Parse(Console.ReadLine());

int max = a;

if ((b > a) && (b > c))
{
    max = b;
}
if ((c > a) && (c > b))
{
    max = c;
}

Console.WriteLine("Максимальное из этих чисел = "+max);