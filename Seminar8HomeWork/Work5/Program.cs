// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int row = 4; // количетсво строк в массиве 
int column = 4;  // количество столбцов в массиве 

int[,] twoArray = new int[row, column];
int buffer = 0;  // значение которое будем вставлять в массив
bool rigthLeft = true;
bool upDown = true;
int count = 0;
int countRow = 0; //счетчик проходов и чего то еще
int countColumn = 0; //счетчик проходов и чего то еще

while (buffer < row * column + 1)
{
    if ((rigthLeft == true) & (upDown == true))     // впарво
    {
        for (int i = 0 + count; i < twoArray.GetLength(0) - count; i++)
        {
            buffer++;
            twoArray[countRow, i] = buffer;
            countColumn = i;
            System.Console.Write($"{twoArray[countRow, i]}{(countRow, i)}");

        }
        upDown = false;
        
    }
    if ((rigthLeft == true) & (upDown == false))     // вниз
    {
        for (int i = 1 + count; i < twoArray.GetLength(1) - count; i++)
        {
            buffer++;
            twoArray[i, countColumn] = buffer;
            countRow = i;
            System.Console.Write($"{twoArray[i, countColumn]}{(i, countColumn)}");
        }
        rigthLeft = false;
    }
    if ((rigthLeft == false) & (upDown == false))     // влево
    {
        for (int i = countRow - count; i >= 1 + count; i--)
        {
            buffer++;
            twoArray[countRow, i] = buffer;
            countColumn = i;
            System.Console.Write($"{twoArray[countRow, i]}{(countRow, i)}");
        }

        upDown = true;
    }
    if ((rigthLeft == false) & (upDown == true))     //вверх
    {
        for (int i = countColumn - count; i >= 1 + count; i--)  // ошибка в countColumn = 0 а должен быть равен 4
        {
            buffer++;
            twoArray[i, countColumn] = buffer;
            countRow = i;
            System.Console.Write($"{twoArray[i, countColumn]}{(i, countColumn)}");
        }
        rigthLeft = true;
        count++;
    }
}