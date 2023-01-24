// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Цифры считать справа налево).

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int searchNum = num / 100 % 10;
if (searchNum < 1)
{
    Console.WriteLine("Третьей цифры нет!!!");
}
else
{
    Console.WriteLine(searchNum);
}