// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

int[,] CreateNewMatrix(int row, int column)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < column; j++)
        {
            matrix[i,j] = rnd.Next(0, 10);
        }
    }   
    return matrix;
}

void PrintMatrix(int[,] matrix, int row, int column)
{
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < column; j++)
        {
            Console.Write(matrix[i,j] + "    ");
        }
        Console.WriteLine();
    }
}  

void SearchRowMaxSum(int[,] matrix, int row, int column)
{   
    int min=100000000;
    int imin=0;
    for(int i = 0; i < row; i++)
    {
        int sum=0;
        for(int j = 0; j < column; j++)
        {
            sum+=matrix[i,j];
        }
            if(sum<min)
            {
                min=sum;
                imin=i;
            }   
    }  
    Console.WriteLine($"The row {imin+1} has min summ of elements: {min}");
}

System.Console.Write("Please, enter the number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Please, enter the number of columns: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.Green;
int[,] matrix = CreateNewMatrix(row, column);
PrintMatrix(matrix, row, column);
SearchRowMaxSum(matrix, row, column);





