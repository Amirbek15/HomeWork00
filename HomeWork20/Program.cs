// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет.


System.Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] FillMatrix(int row, int column)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(0, 10);
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return matrix;
}

int[,] matrix = FillMatrix(row, column);
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int indexNrow = -1;
int indexNcol = -1;
bool f = false;
for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        if(matrix[i,j] == N)
        {
            indexNrow = i;
            indexNcol = j;
            f = true;
            Console.WriteLine("[{0},{1}]", indexNrow, indexNcol);
        }
    }     
} 
if(f)
{
    Console.Write($"Последнее вхождение числа: строка {indexNrow+1}, столбец {indexNcol+1} ");
}
else Console.WriteLine($"Такого числа нет");
Console.WriteLine();

System.Console.Write("Введите номер строки: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите номер столбца: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n > matrix.GetLength(0) || m > matrix.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента равно {matrix[n-1,m-1]}");
}
