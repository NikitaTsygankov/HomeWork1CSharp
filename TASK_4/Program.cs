﻿// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i <= n; i++)
{
    if (i % 2 == 0)
    System.Console.Write(i + ", ");
}
