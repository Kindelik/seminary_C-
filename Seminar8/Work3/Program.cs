// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том,
//  сколько раз встречается элемент входных данных.

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

void CountingNumbers(int[,] array)
{
    int number = 0;
    int count = 0;
    int numberMax = array[0, 0];
    while (number <= numberMax)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (numberMax < array[i, j])
                {
                    numberMax = array[i, j];
                }
                if (number == array[i, j])
                {
                    count++;
                }
            }

        }
        if (count > 0) System.Console.WriteLine($"number {number} occurs in the array {count} times");
        count = 0;
        number++;

    }
}

int m = 4; // количетсво строк в массиве
int n = 4;  // количество столбцов в массиве
int leftRange = 0;  // значение "от" целых чисел массива
int rigthRange = 9;  // значение "до" целых чисел массива включительно

int[,] array = TwoDimArray(m, n, leftRange, rigthRange);
PrintTwoDimArray(array);
CountingNumbers(array);
