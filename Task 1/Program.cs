// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int num = ReadInt("Введите натуральное число N: ");
Console.Write(NaturalNumber(num));
int NaturalNumber(int n)
{
    if (n == 1)
        return n;
    else
    {
        Console.Write(n + ", ");
        NaturalNumber(n - 1);
    }
    return 1;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}