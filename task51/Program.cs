// Задача 51: Задайте двумерный массив.
// Найдите сумму элементов, находящихся на главной диагонали (с
// индексами (0,0); (1;1) и т.д.


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

int GetSumMainDiag(int[,] inArray)
{
    int sum = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        sum += inArray[i,i];
    }
    return sum;
}

System.Console.WriteLine("Введите кол-во строк: ");
int line = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);
int [,] newArray = (GetArray2D(line, col)!);
PrintAraay2D(newArray);
int sum = GetSumMainDiag(newArray);
System.Console.WriteLine($"{sum}");