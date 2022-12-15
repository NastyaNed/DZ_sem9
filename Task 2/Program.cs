// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = ReadInt("Введите M: ");
int N = ReadInt("Введите N: ");
if (N < M)
{
    int temp = N;
    N = M;
    M = temp;
}
Console.WriteLine($"Сумма элементов от {M} до {N} -> {Sum(M, N)}");
int Sum(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    else
    {
        n += Sum(m, n - 1) ;
        return n;
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}