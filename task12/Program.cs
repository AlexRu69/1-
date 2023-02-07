// Напишите программу, которая выводит случайное
// трехзначное число и удаляет вторую цифру этого
// числа.
// ● 456 -> 46
// ● 782 -> 72
// ● 918 -> 98 

Console.Clear();

int num = new Random().Next(100, 1000);
int a1 = num / 100;
int a2 = num % 10;

int resalt = a1*10 + a2;

Console.Write($"{num} -> ");
Console.WriteLine(resalt);

// Console.Write($"{num} -> ");
// Console.Write(a1);
// Console.Write(a2);

