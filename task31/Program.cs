// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

int[] GetArray(int size, int minValue, int maxValue)      // minValue - мин значение/maxValue - максимальное/ size -размер массива
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);  //каждому элементумассива присваиваем значение
    }                                                           // от мин до макс значениий
    return array;
}
int[] inArray = GetArray(12, -9, 9);
Console.WriteLine(String.Join(", ", inArray));        //способ выводамассива

int max = 0;
int min = 0;

foreach (int el in inArray)      //цикл
{
    max += el > 0 ? el : 0;
    min += el < 0 ? el : 0;
}
Console.WriteLine($"Сумма положительных элементов = {max}");
Console.WriteLine($"Сумма отрицательных элементов = {min}");