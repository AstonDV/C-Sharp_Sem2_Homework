// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()!);
int a2 = num % 100 / 10;
if (num < 100 || num > 999)
{
    Console.WriteLine("Введенное число не является трехзначным, попробуйте снова");
}
else
{
    Console.WriteLine(a2);
}