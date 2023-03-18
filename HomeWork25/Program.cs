﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void FromNto1(int A, int N)
{
    if(A == N + 1)
    {
        return;
    }
    FromNto1(A + 1, N);
    Console.Write($"{A}  ");
}

Console.Write("Please, enter any natural number:  ");
int N = Convert.ToInt32(Console.ReadLine());
int A = 1;
FromNto1(A, N);



