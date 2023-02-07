﻿// Напишите программу, которая выводит случайное
// число из отрезка [10, 99] и показывает наибольшую
// цифру числа.

Console.Clear();

int num = new Random().Next(10, 100);   //от 10 до 99 

// если делить число целочисленно на 10 (100, 1000 и т д)
// будет выводится левая цифра. Кол-во нулей равно кол-ву 
// отсекаемых цифр.
// Для деления с остатком % работает то же самое в правую 
// сторону

int a1 = num / 10;
int a2 = num % 10;
int max = a1;

if (a2 > max)
{
    max = a2;    
}
    Console.WriteLine($"Максимальная цифра числа {num} равна {max}");
