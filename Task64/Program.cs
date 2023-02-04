// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Clear();

Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

PrintNumbers(n, 1);

void PrintNumbers(int start, int end)
{
    Console.Write($"{start} ");
    if (end == start) return;
    PrintNumbers(start - 1, end);
}