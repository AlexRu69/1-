// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
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

int[] inArray = GetArray(25, -99, 99);
Console.WriteLine(String.Join(", ", inArray)); 
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

bool FindeElement(int[] XXX, int num)
{
    foreach(int el in inArray)
    {
        if(el == num)
        {
            return true;
        }
    }
    return false;
}

if(FindeElement(inArray, num))
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}