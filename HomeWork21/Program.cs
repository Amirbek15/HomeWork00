// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

System.Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] FillMatrix(int n, int m)
{
    int[,] matrix = new int[n, m];
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

int[,] matrix = FillMatrix(n, m);

for(int j = 0; j < matrix.GetLength(1); j++)
{
    double result = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        result = result + matrix[i,j];
    }
    result = Math.Round((result / n),1);
    Console.Write(result + "; ");
}











