// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

Console.Clear();

int[,] GetArray2D(int a, int b, int minVolue, int maxVolue)
{
    int[,] array = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            array[i, j] = new Random().Next(minVolue, maxVolue + 1);
        }
    }
    return array;
}

void PrintAraay2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        System.Console.WriteLine();
    }
}

System.Console.WriteLine("Введите кол-во строк: ");
int line = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);
int [,] newArray = (GetArray2D(line, col, -9, 9));
PrintAraay2D(newArray);
System.Console.WriteLine();