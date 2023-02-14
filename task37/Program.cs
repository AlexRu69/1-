// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] MultArray(int[] array)
{
    int size = array.Length / 2;     //Задаём переменную равную половине длинне входящего массива
    if (array.Length % 2 != 0) size++;   //Провека. Если размер входящего массива делится пополам без остатка, прибавляем 1.
    int[] result = new int[size];         //Задаём массив который получим на выходе, размером size
    for (int i = 0; i < array.Length / 2; i++)   // Создаём цикл который делит входящий мвссив пополам и переберает все члены
    {
        result[i] = array[i] * array[array.Length - 1 - i];  // выполняем умножение первого членна входящего массива на 
    }                                                        // последний. Второй и предпослед соответственно
    if (array.Length % 2 != 0)   
        result[size - 1] = array[array.Length / 2];
    return result;
}
int[] array1 = GetArray(5, -9, 9);
Console.WriteLine(string.Join(",", array1));
int[] array2 = MultArray(array1);
Console.WriteLine(string.Join(",", array2));