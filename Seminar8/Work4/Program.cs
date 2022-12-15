// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

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


int[,] CopyArrMinusRowColumn(int[,] array)      // метод для решения задачи
{
    int minimumDigit = array[0, 0];                // Поиск минимального значение и запись его индексов
    int minArrayRow = 0;
    int minArrayColumn = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (minimumDigit > array[i, j])
            {
                minimumDigit = array[i, j];
                minArrayRow = i;
                minArrayColumn = j;
            }
        }
    }

    System.Console.WriteLine();                                                        // для проверки работоспособности
    System.Console.WriteLine("Наименьший элемент "+ minimumDigit + " " + '[' + minArrayRow + "," + minArrayColumn + ']');
    System.Console.WriteLine();

    int m = 0;                                                          // для счетчика строк нового массива
    int n = 0;                                                          // для счетчика столбцов нового массива
    int[,] newArr = new int[array.GetLength(0)-1, array.GetLength(1)-1];   // Создание нового массива

    for (int i = 0; i < array.GetLength(0); i++)      // Записть значений в новый массив за инсключением строки и столбца меньшего элемента
    {
        if (i != minArrayRow)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j != minArrayColumn)

                {
                    newArr[m, n] = array[i, j];
                    n++;
                }
                else
                {
                    continue;
                }
            }
            m++;
            n = 0;
        }
        else
        {
            continue;
        }
    }
    return newArr;
}

int m = 4; // количетсво строк в массиве
int n = 4;  // количество столбцов в массиве
int leftRange = 0;  // значение "от" целых чисел массива
int rigthRange = 9;  // значение "до" целых чисел массива включительно

int[,] array = TwoDimArray(m, n, leftRange, rigthRange);
PrintTwoDimArray(array);
int[,] newArray = CopyArrMinusRowColumn(array);
PrintTwoDimArray(newArray);
