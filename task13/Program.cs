// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int digit = a.ToString().Length;

if  (digit  < 3 )
{
    Console.WriteLine($"{a} -> Третьей цифры нет");
}
else
{
    string stringNumber = Convert.ToString(a);
    Console.Write(a);
    Console.WriteLine(" -> "+stringNumber[2]);
}