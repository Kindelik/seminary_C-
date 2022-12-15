// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

void ReverseRowsColums(int[,] array)   //Переворот строк в столбцы
{
    int rowsReverse = array.GetLength(0) - 1;
    int columsReverse = array.GetLength(1) - 1;
    int temp;
    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < i; j++)
            {
                temp = array[i, j];
                array[i, j] = array[j,i];
                array[j,i] = temp;
            }
        }
    }
    else System.Console.WriteLine("Cтроки должны быть равны столбцам");
}

int m = 4; // количетсво строк в массиве
int n = 4;  // количество столбцов в массиве
int leftRange = 0;  // значение "от" целых чисел массива
int rigthRange = 10;  // значение "до" целых чисел массива включительно

int[,] array = TwoDimArray(m, n, leftRange, rigthRange);
PrintTwoDimArray(array);
ReverseRowsColums(array);
System.Console.WriteLine();
PrintTwoDimArray(array);