// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumFromNtoM(int N, int M)
{
    if(M == N)
    {
        return N;
    }
    return M += SumFromNtoM(N, M - 1);
}

int SumFromMtoN(int M, int N)
{
    if(N == M)
    {
        return M;
    }
    return N+SumFromMtoN(M, N - 1);
}

Console.Write("Please, enter any natural number:  ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, enter another natural number:  ");
int N = Convert.ToInt32(Console.ReadLine());
if(M > N)
{
    Console.Write($"The summ of all numbers from {N} to {M} is: {SumFromNtoM(N, M)}");
}
else
    Console.Write($"The summ of all numbers from {M} to {N} is: {SumFromMtoN(M, N)}");