// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());
int digit = a.ToString().Length;

if  (digit  < 3 || digit  > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    string stringNumber = Convert.ToString(a);
    Console.WriteLine("Вторая цифра этого числа -> "+stringNumber[1]);
}