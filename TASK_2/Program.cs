//Напишите программу, которая принимает на вход три числа и выдаёт максимальное

Console.WriteLine("ВВЕДИТЕ ПЕРВОЕ ЧИСЛО:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("ВВЕДИТЕ ВТОРОЕ ЧИСЛО:");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("ВВЕДИТЕ ТРЕТЬЕ ЧИСЛО:");
int c = int.Parse(Console.ReadLine());

int max = a;

if (a < b) max = b;
if (b < c) max = c;

System.Console.Writeline("Максимальное из этих чисел = "+max);