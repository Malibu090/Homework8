// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

const int leftRange = 1;
const int rightRange = 10;
// const int rows = 2;
// const int columns = 2;

void ProductTwoMatrix(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] productMatrix = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];
    for (int i = 0; i < productMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < productMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrixOne.GetLength(1); k++)
            {
                sum += matrixOne[i, k] * matrixTwo[k, j];
            }
            productMatrix[i, j] = sum;
        }
    }
    Console.WriteLine();
    OutputArray(productMatrix);
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

// ввести размеры каждой матрицы
int rows1 = EnterNumber("Input number of rows matrixOne: ");
int columns1 = EnterNumber("Input number of columns matrixOne: ");
int rows2 = EnterNumber("Input number of rows matrixTwo: ");
int columns2 = EnterNumber("Input number of columns matrixTwo: ");

// произведение матриц можно найти, если количество столбцов первой матрицы равно количеству строк второй матрицы 
if (columns1 == rows2)
{
    // задайте 2 матрицы с рандомными числами
    int[,] matrixOne = CreateArrayWithRandomNumbers(rows1, columns1, leftRange, rightRange);
    int[,] matrixTwo = CreateArrayWithRandomNumbers(rows2, columns2, leftRange, rightRange);

    // вывести 2 матрицы с рандомными числами
    OutputArray(matrixOne);
    Console.WriteLine();
    OutputArray(matrixTwo);

    // вычислить и вывести произведение этих матриц (размер новой матрицы будет равен количеству строк первой и количеству столбцов второй)
    ProductTwoMatrix(matrixOne, matrixTwo);
}
else Console.WriteLine("The product of the matrices cannot be found because the number of columns of the first matrix is not equal to the number of rows of the second matrix");