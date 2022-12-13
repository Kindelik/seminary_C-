// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[] ArithmeticMean(int[,] array)
{
    double[] arrayArifmetic = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++) // цикл для столбцов
    {
        for (int i = 0; i < array.GetLength(0); i++)  //цикл для строк
        {
            arrayArifmetic[j] += array[i, j];
        }
        arrayArifmetic[j] /= (double)array.GetLength(0);
        arrayArifmetic[j] = Math.Round(arrayArifmetic[j],1); //округляем значение до десятых
    }
    return arrayArifmetic;
}

void PrintTwoDimArray(int[,] array)  // метод вывода двумерного массива в терминал
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

void PrintArray(double[] col)             //Метод - Вывести одномерный массив в терминал
{
    Console.Write("[");
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write($" {col[i]} ");
    }
    Console.Write("]");
}


int m = 3; // количетсво строк в массиве
int n = 4;  // количество столбцов в массиве
int leftRange = 0;  // значение "от" целых чисел массива
int rigthRange = 10;  // значение "до" целых чисел массива включительно

int[,] array = TwoDimArray(m, n, leftRange, rigthRange);  // создаем рандомный двумерный массив
double[] meanValues = ArithmeticMean(array); // массив, в котоырй будем складывать полученные Средние арифметические столбцов
PrintTwoDimArray(array);  // выводим в терминал двумерный массив
System.Console.WriteLine($"Среднее арифметическое каждого столбца {'[' + string.Join("; ", meanValues) + ']'}"); // выводим в терминал массив со средними арифметическими стоблцов
