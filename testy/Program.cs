
/* 

int[,,] ThreeDimArray(int length, int heigth, int weigth, int leftRange, int rigthRange)
{
    int[,,] array = new int[length, heigth, weigth];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(leftRange, rigthRange + 1);

            }
        }
    }
        for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 1; k < array.GetLength(2); k++)
            {
                if(array[i, j, k] == array[i, j, k-1])

                array[i, j, k] = new Random().Next(leftRange, rigthRange + 1);

            }
        }
    }
return array;
}


int row = 3; // длина массива
int column = 3;  // ширина массива
int weigth = 3;  // высота массива
int leftRange = 1; // значение "от" целых чисел массива
int rigthRange = 10;  // значение "до" целых чисел массива включительно

int[,,] cubeArray = ThreeDimArray(row, column, weigth, leftRange, rigthRange);

int[] arrRandom = new int[cubeArray.Length];
int temp = 0;
for (int i = 0; i < arrRandom.Length; i++)
{
    arrRandom[i] = new Random().Next(30);
    temp = arrRandom[i];
    if (i >= 1)
    {
        for (int j = 0; j < i; j++)
        {
            while (arrRandom[i] == arrRandom[j])
            {
                arrRandom[i] = new Random().Next(30);
                j = 0;
                temp = arrRandom[i];
            }

            temp = arrRandom[i];
        }
    }
    Console.Write($" {arrRandom[i]} , ");
}

 */


static IEnumerable<int> UniqueRandomNumbers(int leftRange, int rigthRange)
{
    Random rand = new();
    int[] values = Enumerable.Range(leftRange, rigthRange).ToArray();
    int i = values.Length;
    while (i > 0)
    {
        int j = rand.Next(i--);
        yield return values[j];
 
        (values[i], values[j]) = (values[j], values[i]);
    }
}

void PrintThreeDimArray(int[,,] array)  // метод вывода двумерного массива в терминал
{
    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
                if (k < array.GetLength(2) - 1) System.Console.Write(" ; ");
            }

        }
        System.Console.Write("]");
        System.Console.WriteLine();
    }
}

int leftRange = 1; // значение "от" целых чисел массива
int rigthRange = 10;  // значение "до" целых чисел массива включительно

int[,,] arr = new int[2, 2, 2];
 
IEnumerator<int> value = UniqueRandomNumbers(leftRange, rigthRange).GetEnumerator();
 
for (int i = 0; i < arr.GetLength(0); i++)
for (int j = 0; j < arr.GetLength(1); j++)
for (int k = 0; k < arr.GetLength(2); k++)
{
    if (!value.MoveNext())
    {
        Console.WriteLine("Упс, уникальные числа закончились!");
        return;
    }
 
    arr[i, j, k] = value.Current;
}

PrintThreeDimArray(arr);