// Написать программу, в которой при вводе определяется четность числа

Console.WriteLine("Введите число");

int number = int.Parse(Console.ReadLine());


if (number % 2 == 0)
{
    Console.WriteLine("Число является четным");
}
else
{
    Console.WriteLine("Число не четное");
}