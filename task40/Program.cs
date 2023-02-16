// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


Console.Clear();

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine()!);

bool GetTriangle(int a, int b, int c)
{
    return a < b + c && b < c + a && c < a + b;
}

if(GetTriangle(num1, num2, num3))
{
    System.Console.WriteLine("Существует");
}
else
{
    System.Console.WriteLine("Не существует");
}