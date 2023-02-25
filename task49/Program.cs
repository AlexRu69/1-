// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.


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

void GetModifedArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if (i % 2 != 0) continue;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (j % 2 == 0) inArray[i, j] *= inArray[i, j];
        }
    }
}

System.Console.WriteLine("Введите кол-во строк: ");
int line = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);
int[,] newArray = (GetArray2D(line, col, -9, 9));
PrintAraay2D(newArray);
System.Console.WriteLine();
GetModifedArray(newArray);
PrintAraay2D(newArray);
