// Напишите программу, которая по заданному номеру
// четверти, показывает диапазон возможных координат
// точек в этой четверти (x и y).

Console.Clear();

Console.Write("Введите число от 1 до 4: ");
int quarter = int.Parse(Console.ReadLine()!);

// if (quarter == 1)
// {
//     Console.WriteLine("При положительных значениях X и Y");
// }
// else if (quarter == 2)
// {
//     Console.WriteLine("При положительном Y и отрицательном X");
// }
// else if (quarter == 3)
// {
//     Console.WriteLine("При отрицательных X и Y");
// }
// else if (quarter == 4)
// {
//     Console.WriteLine("При положительном X и отрицательном Y");
// }
// else
// {
//     Console.Write("Введите число от 1 до 4: ");
// }

switch (quarter)
{
    case 1:
        Console.WriteLine("При положительных значениях X и Y");
        break;
    case 2:
        Console.WriteLine("При положительном Y и отрицательном X");
        break;
    case 3:
        Console.WriteLine("При отрицательных X и Y");
        break;
    case 4:
        Console.WriteLine("При положительном X и отрицательном Y");
        break;
    default:
    {
        Console.Write("Введите число от 1 до 4: ");
        break;
    }
}