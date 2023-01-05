// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

const int leftRange = 0;
const int rightRange = 10;

void MinSumOfRowElements(int[,] matrix, out int minSumRow)
{
    minSumRow = 0;
    int minSum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        Console.WriteLine("the sum of row " + (i + 1) + " is equal to " + sum);
        if (i == 0)
        {
            minSum = sum;
            minSumRow = i + 1;
        }
        else if (minSum > sum)
        {
            minSum = sum;
            minSumRow = i + 1;
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

// ввести размер массива
int rows = EnterNumber("Input number of rows: ");
int columns = EnterNumber("Input number of columns: ");

// создать массив с рандомными числами
int[,] matrix = CreateArrayWithRandomNumbers(rows, columns, leftRange, rightRange);
// вывести массив в консоль
OutputArray(matrix);
// посчитать сумму элементов в каждой строке и выдать номер строки с наименьшей суммой элементов
MinSumOfRowElements(matrix, out int minSumRow);
System.Console.WriteLine(minSumRow + " string - a string with the minimum sum of elements");