﻿// Напишите программу , которая выводит случайное число из отрезка [10,99] и 
// показывает наибольшую цифру числа.
// например: 78 -> 8; 12 -> 2; 85 -> 8

Console.Clear();
int num = new Random().Next(10,100);
Console.WriteLine(num);
int a1 = num/10;
int a2 = num%10;
int max = a1;
if (a2 > max) 
{ 
    max = a2;
}
Console.WriteLine($"Максимальная циффра в числее {num} -> {max} ");

