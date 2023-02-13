// Демонстрация решения
// Задача №17. Напишите программу, которая
// принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти
// плоскости, в которой находится эта точка.


Console.Clear();

Console.WriteLine("Введите X: ");
int X = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите Y: ");
int Y = int.Parse(Console.ReadLine()!);

if (Y > 0)
{
    if (X > 0)
    {
    Console.WriteLine("Первая четверь");
    }
    else
    {
        Console.WriteLine("Вторая четверть");
    }
}
else
{
    if (X > 0)
    {
    Console.WriteLine("Четвёртая четверь");
    }
    else
    {
        Console.WriteLine("Третья четверть");
    }
}