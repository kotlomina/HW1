// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите день недели (пн - 1, вт - 2... вс - 7) ");
int a = int.Parse(Console.ReadLine());

if  (a  > 7 )
{
    Console.WriteLine($"{a} -> не верные данные");
}
else
    if  (a  < 6 )
    {
        Console.WriteLine($"{a} -> нет");
    }
    else
    {
       Console.WriteLine($"{a} -> да"); 
    }