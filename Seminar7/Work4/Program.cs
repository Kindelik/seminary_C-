// Задача 51: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] TwoDimArray(int rows, int columns, int leftRange, int rigthRange)
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

int SumDiagonal(int[,] array)
{
    int sum = 0;
    int j = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {

        if (i == j) sum = sum + array[i, j];

        j++;
    }
    return sum;
}

void PrintTwoDimArray(int[,] array)
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

int m = 5;
int n = 5;
int leftRange = 0;
int rigthRange = 9;

int[,] array = TwoDimArray(m, n, leftRange, rigthRange);
PrintTwoDimArray(array);

int summa = SumDiagonal(array);
System.Console.WriteLine(summa);