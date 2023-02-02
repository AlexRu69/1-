// Напишите программу, которая будет
// выдавать название дня недели по заданному номеру.

Console.Clear();

Console.Write("Напишите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine()!);

if (number == 1)
{
    Console.WriteLine("Понедельник");
}
else if (number == 2)        // если выполняется условие дальше проверка остановится и т.д. по коду
{
    Console.WriteLine("Вторник");
}
else if (number == 3)
{
    Console.WriteLine("Среда");
}
else if (number == 4)
{
    Console.WriteLine("Четверг");
}
else if (number == 5)
{
    Console.WriteLine("Пятница");
}
else if (number == 6)
{
    Console.WriteLine("Суббота");
}
else if (number == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Введите число от 1 до 7: ");
}
