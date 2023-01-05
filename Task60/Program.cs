// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

const int leftRange = 10;
const int rightRange = 100;
const int rows = 2;
const int columns = 2;
const int pages = 2;

int[,,] CreateArrayWithRandomNumbers(int rows, int columns, int pages, int leftRange, int rightRange)
{
    int[,,] array = new int[rows, columns, pages];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < pages; k++)
            {
                array[i, j, k] = new Random().Next(leftRange, rightRange);
            }
        }
    }
    return array;

}

int[,,] OutputArrayWithRandomNumbers(int[,,] cube, int rows, int columns, int pages)
{
    for (int i = 0; i < rows; i++)
    {
        Console.Write(" ");
        for (int j = 0; j < columns; j++)
        {
            Console.WriteLine();
            for (int k = 0; k < pages; k++)
            {
                Console.Write(cube[i, j, k] + $"{(i, j, k)} ");
            }
        }
    }
    return cube;

}

int[,,] cube = CreateArrayWithRandomNumbers(rows, columns, pages, leftRange, rightRange);
OutputArrayWithRandomNumbers(cube, rows, columns, pages);