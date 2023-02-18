// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


Console.Clear();

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

int[] GetArray(int a)
{
    int[] Array = new int[a];
    Array[0] = 0;
    Array[1] = 1;
    for (int i = 2; i < Array.Length ; i++)
    {
        
        Array[i] = Array[i - 1] + Array[i - 2];
    }
    return Array;
}

int[] array = GetArray(N);
System.Console.WriteLine(string.Join(", ", array));