// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Clear();

System.Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

string ConvertDecToBin(int N)    //строчка конвертация десятичного в двоичную
{
    string res = String.Empty;   // строковая переменная с размером пустая строка!
    while (N != 0)
    {
        res = (N % 2).ToString() + res;   // Переварачивает после диления. ToFtring преобразовывает в строку результат
        N /= 2;                           // деления с остатком. Так как это строка +res пребавляет следующий результат
    }    
    return res;                                // в конец строки. Поэтому не надо переварачивать
}              

System.Console.WriteLine(ConvertDecToBin(number)!);