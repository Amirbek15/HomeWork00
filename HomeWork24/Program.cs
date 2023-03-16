// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

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
    Console.WriteLine("---------");
}  

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2, int row, int column)
{
    int i=0, j=0;
    int[,] matrix = new int[row, column];
    matrix[i,j]=matrix1[i,j]*matrix2[i,j]+matrix1[i,j+1]*matrix2[i+1,j];
    matrix[i,j+1]=matrix1[i,j]*matrix2[i,j+1]+matrix1[i,j+1]*matrix2[i+1,j+1];
    matrix[i+1,j]=matrix1[i+1,j]*matrix2[i,j]+matrix1[i+1,j]*matrix2[i+1,j];
    matrix[i+1,j+1]=matrix1[i+1,j]*matrix2[i,j+1]+matrix1[i+1,j+1]*matrix2[i+1,j+1];
    return matrix;
}

System.Console.Write("Please, enter the number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Please, enter the number of columns: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = CreateMatrix(row, column);
PrintMatrix(matrix1, row, column);
int[,] matrix2 = CreateNewMatrix(row, column);
PrintMatrix(matrix2, row, column);
int[,] matrix = MultiplyMatrix(matrix1, matrix2, row, column);
PrintMatrix(matrix, row, column);


