﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
    Console.WriteLine("---------------------");
}  

void ReverseRow(int[,] matrix, int row, int column)
{
    int temp=0, max=0;
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < column; j++)
        {
            for(int z = 1; z < column-j; z++)
            {
                if(matrix[i,j]>=matrix[i,j+z])
                {
                    max=matrix[i,j];
                }
                else
                {
                    max=matrix[i,j+z];
                    temp=matrix[i,j];
                    matrix[i,j]=max;
                    matrix[i,j+z]=temp;
                }
            }
            Console.Write(matrix[i,j] + "    ");
        }  
        Console.WriteLine(); 
    } 
}  

System.Console.Write("Please, enter the number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Please, enter the number of columns: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = CreateNewMatrix(row, column);
PrintMatrix(matrix, row, column);
ReverseRow(matrix, row, column);



