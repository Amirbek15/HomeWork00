// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AccermanMeth(int M, int N)
{
    if(M > 0 && N > 0)
    { 
        return AccermanMeth(M - 1, AccermanMeth(M, N - 1));
    }
    else
    { 
        if(M > 0 && N == 0) 
        {
            return AccermanMeth(M - 1, 1);
        }
        else
        {
            return N + 1; 
        }
    }
}
    

Console.Write("Please, enter any natural number: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, enter another natural number: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"The result of Accermann' function is: {AccermanMeth(M, N)}");


