// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.
// Набор данных Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 } 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

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

int[] ExpandArray(int[,] array)  //перевод двумерного масссива в одномерный
{
    int[] array2DPerLine = new int[array.GetLength(0) * array.GetLength(1)];
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)   
    {
        for (int j = 0; j < array.GetLength(1); j++)   
        {
            array2DPerLine[index] = array[i, j];
            index++;
        }
    }
    return array2DPerLine;
}

void Calculate(int[] array)   // сортируем массив   1,1,2,2,2,3,3 и тд
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
}

void CountElements(int[] array)  //печатаем частотный словарь
{
    int count = 1;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] == array[i + 1]) count++;
        else
        {
            System.Console.WriteLine($"{array[i]} -> {count} раз ");
            count = 1;
        }
    }
    System.Console.WriteLine($"{array[array.Length - 1]} -> {count} раз ");
}

System.Console.WriteLine("Введите кол-во строк: ");
int line = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);
int[,] newArray = (GetArray2D(line, col, 1, 5)!);
System.Console.WriteLine();
PrintAraay2D(newArray);
System.Console.WriteLine();
int[] array2DPerLine = ExpandArray(newArray);
Calculate(array2DPerLine);
CountElements(array2DPerLine);