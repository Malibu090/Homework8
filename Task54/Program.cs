// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

const int leftRange = 0;
const int rightRange = 10;
// const int rows = 3;
// const int columns = 4;

void OrganizeRowsMaxToMin(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    int buffer = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = buffer;
                }
            }
        }
    }
}

void OutputArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] CreateArrayWithRandomNumbers(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(leftRange, rightRange);
        }
    }
    return array;
}

int EnterNumber(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int rows = EnterNumber("Input number of rows: ");
int columns = EnterNumber("Input number of columns: ");

int[,] matrix = CreateArrayWithRandomNumbers(rows, columns, leftRange, rightRange);

OutputArray(matrix);

OrganizeRowsMaxToMin(matrix);
System.Console.WriteLine();
OutputArray(matrix);