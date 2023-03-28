//Напишите программу, которая принимает на вход три числа и выдаёт максимальное

Console.WriteLine("ВВЕДИТЕ ПЕРВОЕ ЧИСЛО:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("ВВЕДИТЕ ВТОРОЕ ЧИСЛО:");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("большее число"); 
    Console.WriteLine(a);
    Console.WriteLine("меньшее число");
    Console.WriteLine(b);
}
else 
{
    Console.WriteLine("большее число"); 
    Console.WriteLine(b);
    Console.WriteLine("меньшее число");
    Console.WriteLine(a);  
}