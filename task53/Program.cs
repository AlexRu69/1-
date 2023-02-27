// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

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

void SwapsLines(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {


        int temp = array[0, j];                 //метод пузырька. если меняем строки местами, цикд запускаем по столбцам
        array[0, j] = array[array.GetLength(0) - 1, j];  // меняем местами первый и последний элемент столбца
        array[array.GetLength(0) - 1, j] = temp;

    }
}

System.Console.WriteLine("Введите кол-во строк: ");
int line = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);
int[,] newArray = (GetArray2D(line, col)!);
System.Console.WriteLine();
PrintAraay2D(newArray);
SwapsLines(newArray);
System.Console.WriteLine();
PrintAraay2D(newArray);


