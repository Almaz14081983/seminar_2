// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите число  ");
int a1 = int.Parse(Console.ReadLine());
if((9<a1) & (a1<100))
{
    Console.WriteLine("третьей цифры нет");
}
if((100<a1) & (a1<1000))
{
    int a2 = a1%10;
    Console.WriteLine($"цифра: {a2}");
}
if((9999<a1) & (a1<100000))
{
    int a3 = a1%1000;
    int a4 = a3/100;
    Console.WriteLine($"цифра: {a4}");
}

