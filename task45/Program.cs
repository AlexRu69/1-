// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

//Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)      // minValue - мин значение/maxValue - максимальное/ size -размер массива
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);  //каждому элементумассива присваиваем значение
    }                                                           // от мин до макс значениий
    return array;
}

int[] GetArrayCopy(int[] inArray)
{
    int[] arrayCopy = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        arrayCopy[i] = inArray[i];
    }
    return arrayCopy;
}

int[] array = GetArray(5, 1, 9);
System.Console.WriteLine(string.Join(", ", array));
int[] array2 = (GetArrayCopy(array));
System.Console.WriteLine(string.Join(", ", array2));
