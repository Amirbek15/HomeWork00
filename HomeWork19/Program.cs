// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] FillMatrixWithRandom(int m, int n)
{ 
    Random x = new Random();
    double[,] matrix = new double[m, n];
    Random rnd = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Convert.ToDouble(x.Next(-1000, 1000)/10.0);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

System.Console.Write("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.Green;
double [,] matrix = FillMatrixWithRandom(m, n);
PrintMatrix(matrix);




