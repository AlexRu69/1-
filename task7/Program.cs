// Напишите программу, которая принимает
// на вход трёхзначное число и на выходе показывает
// последнюю цифру этого числа.

Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine(number % 10);
