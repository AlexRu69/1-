// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aij = i+j.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


Console.Clear();

int[,] GetArray2D(int a, int b)
{
    int[,] array = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            array[i, j] = i + j;  
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
int [,] newArray = (GetArray2D(line, col)!);
PrintAraay2D(newArray);
System.Console.WriteLine();