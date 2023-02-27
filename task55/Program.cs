// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

int[,] ChangeArray(int[,] array2D)
{
    int[,] arrayRes = new int[array2D.GetLength(1), array2D.GetLength(0)];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            arrayRes[j, i] = array2D[i, j];
        }
    }
    return arrayRes;
}

System.Console.WriteLine("Введите кол-во строк: ");
int line = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);
int[,] newArray = (GetArray2D(line, col, 1, 9)!);
System.Console.WriteLine();
PrintAraay2D(newArray);
System.Console.WriteLine();
if (line != col)
{
    System.Console.WriteLine("операция не возможна: ");
}
else
{
    int[,] result = ChangeArray(newArray);
    PrintAraay2D(result);
}