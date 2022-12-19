int row = 4; // количетсво строк в массиве 
int column = 4;  // количество столбцов в массиве 

int[,] twoArray = new int[row, column];
int meaning = 0;  // значение которое будем вставлять в массив
bool rigthLeft = true;
bool upDown = true;
int count = 0;
int countRow = 0; //счетчик проходов и чего то еще
int countColumn = 0; //счетчик проходов и чего то еще

while (count<3)
{
    if ((rigthLeft == true) & (upDown == true))     // двигаемся вправо
    {
        for (int i = 0 + count; i < 4 - count; i++)
        {
            meaning++;
            twoArray[countRow, i] = meaning;
            countColumn = i;
            System.Console.Write($"{twoArray[countRow, i]}{(countRow, i)}"); // проверочный
        }
        upDown = false;
    }
    if ((rigthLeft == true) & (upDown == false))     // двигаемся вниз
    {
        for (int i = 1 + count; i < 4 - count; i++)
        {
            meaning++;
            twoArray[i, countColumn] = meaning;
            countRow = i;
            System.Console.Write($"{twoArray[i, countColumn]}{(i, countColumn)}");
        }
        rigthLeft = false;
    }
    if ((rigthLeft == false) & (upDown == false))     // двигаемся влево
    {
        for (int i = 2 - count; i >= 0 + count; i--)
        {
            meaning++;
            twoArray[countRow, i] = meaning;
            countColumn = i;
            System.Console.Write($"{twoArray[countRow, i]}{(countRow, i)}");    // проверочный
        }
        upDown = true;
    }
    if ((rigthLeft == false) & (upDown == true))     // двигаемся вверх
    {
        for (int i = 2 - count; i > 0 + count; i--) 
        {
            meaning++;
            twoArray[i, countColumn] = meaning;
            countRow = i;
            System.Console.Write($"{twoArray[i, countColumn]}{(i, countColumn)}");
        }
        rigthLeft = true;
        count++;
    }
}

