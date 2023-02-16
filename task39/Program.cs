// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)      // minValue - мин значение/maxValue - максимальное/ size -размер массива
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);  //каждому элементумассива присваиваем значение
    }                                                           // от мин до макс значениий
    return array;
}

//1й способ

void ReverseArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)   // перебераем до середины
    {
        int temp = inArray[i];                           // меняем местами по принципу пузырька
        inArray[i] = inArray[inArray.Length - 1 - i];    // входящий массив меняется
        inArray[inArray.Length - 1 - i] = temp;
    }
}

int[] array = GetArray(5, -10, 10);
System.Console.WriteLine(string.Join(", ", array));
ReverseArray(array);
System.Console.WriteLine(string.Join(", ", array));

// 2й способ

int[] ReverseArray2(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];    // ставим на первое место нового массива послед элемент входящего
    } 
    return result;
}

int[] array = GetArray(5, -10, 10);
System.Console.WriteLine(string.Join(", ", array));
int[] array2 = ReverseArray2(array);
System.Console.WriteLine(string.Join(", ", array2));

