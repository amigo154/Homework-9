﻿// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();

Console.WriteLine("Введите число M:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(SumNumbers(m, n));

int SumNumbers(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;            
    else if (N == 0) return (M * (M + 1)) / 2;     
    else if (M == N) return M;                      
    else if (M < N) return N + SumNumbers(M, N - 1);
    else return N + SumNumbers(M, N + 1);            
}

