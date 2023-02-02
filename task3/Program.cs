// Напишите программу, которая на вход
// принимает одно число (N), а на выходе показывает
// все целые числа в промежутке от -N до N.

Console.Clear();

Console.Write("Напишите число: ");
int N = int.Parse(Console.ReadLine()!);
int K = -N;

while (K <= N)
{
    Console.Write($"{K} ");
    K++;
}
