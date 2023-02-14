// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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

int[] NewArray = GetArray(123, 0, 1000);
int Serch(int[] array)
{
    int count = 0;
    foreach(int el in NewArray)
    {
        if(el > 9 && el < 100)
        {
            count ++;
        }
    }
    return count;
}

Console.WriteLine(String.Join(", ", NewArray)); 
int end = Serch(NewArray);
Console.WriteLine(end);