// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] GetArray(int size, int minValue, int maxValue)      // minValue - мин значение/maxValue - максимальное/ size -размер массива
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);  //каждому элементумассива присваиваем значение
    }                                                           // от мин до макс значениий
    return array;
}

void SigChenge(int[] name)      // Функция замены знака
{
    for (int i = 0; i < name.Length; i++)
    {
        name[i] *= -1;
    }
}
int[] inArray = GetArray(12, -9, 9);
Console.WriteLine(String.Join(", ", inArray));        //способ выводамассива
SigChenge(inArray);
Console.WriteLine(String.Join(", ", inArray));        //способ выводамассива
