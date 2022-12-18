// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void PrintTwoDimArray(int[,] array)  // метод вывода двумерного массива в терминал
{
    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}");
            if (j < array.GetLength(1) - 1) System.Console.Write(" ; ");
        }
        System.Console.Write("]");
        System.Console.WriteLine();
    }
}

int[,] TwoDimArray(int rows, int columns, int leftRange, int rigthRange)  // Метод для создания двумерного массива и заполнение его рандомными значениями
{

    int[,] array = new int[rows, columns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(leftRange, rigthRange + 1);
        }
    }
    return array;
}

void MultiplicationTwoMatrix(int[,] arrayOne, int[,] arrayTwo, out int[,] multMatrix)
{
   multMatrix = new int [arrayOne.GetLength(0),arrayTwo.GetLength(1)]; 

    if (arrayOne.GetLength(0) != arrayTwo.GetLength(1))
    {
      System.Console.WriteLine("\n incorrect - the row of matrix One must be equal to the column of matrix Two");
      return;
    }


    for (int i = 0; i < multMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < multMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < arrayOne.GetLength(1); k++)
            {
                sum += arrayOne[i, k] * arrayTwo[k, j];
            }
            multMatrix[i, j] = sum; 

        }
    }
    PrintTwoDimArray(multMatrix);
}


int rowMatrixOne = 4; // количетсво строк в массиве 1
int columnMatrixOne = 3;  // количество столбцов в массиве 1
int leftRangeMatOne = 1;  // значение "от" целых чисел массива 1
int rigthRangeMatOne = 10;  // значение "до" целых чисел массива включительно 1

int[,] matrixOne = TwoDimArray(rowMatrixOne, columnMatrixOne, leftRangeMatOne, rigthRangeMatOne);
PrintTwoDimArray(matrixOne);

int rowMatrixTwo = 3; // количетсво строк в массиве 1
int columnMatrixTwo = 4;  // количество столбцов в массиве 1
int leftRangeMatTwo = 1;  // значение "от" целых чисел массива 1
int rigthRangeMatTwo = 10;  // значение "до" целых чисел массива включительно 1

int[,] matrixTwo = TwoDimArray(rowMatrixTwo, columnMatrixTwo, leftRangeMatTwo, rigthRangeMatTwo);
PrintTwoDimArray(matrixTwo);
MultiplicationTwoMatrix(matrixOne,matrixTwo, out int[,] multMatrix);
