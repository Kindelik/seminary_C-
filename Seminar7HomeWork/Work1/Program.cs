// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] TwoDimArray(int rows, int columns, int leftRange, int rigthRange)
{

    double[,] array = new double[rows, columns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(leftRange, rigthRange + 1) + new Random().NextDouble();// Положить новое рандомное дробное число в индекс
        array[i,j] = Math.Round(array[i,j], 1);    // округляем значения в массиве до десятых долей
        }
    }
    return array;
}

void PrintTwoDimArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int m = 3; // количетсво строк в массиве
int n = 4;  // количество столбцов в массиве
int leftRange = -10;  // значение "от" целых чисел массива
int rigthRange = 10;  // значение "до" целых чисел массива включительно

double[,] array = TwoDimArray(m, n, leftRange, rigthRange);

PrintTwoDimArray(array);