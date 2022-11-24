// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6



// Математическое решение


Console.Clear();
Console.WriteLine("Enter a number");
int numberA = Convert.ToInt32(Console.ReadLine());   //ввод числа с терминала
int numberThree = numberA;
if (numberA > 99)
{
    while (numberThree > 999)
    {
        numberThree = (numberThree - (numberThree % 10)) / 10;
    }
    numberThree = numberThree % 10;
    Console.WriteLine(numberThree);
}
else
{
    Console.WriteLine("This number does not have a third digit");
}



















// Решение через string
/* 
Console.Clear();
Console.WriteLine("Enter a number");
int numberA = Convert.ToInt32(Console.ReadLine());   //ввод числа с терминала
if (numberA > 99)                 // проверка на трехзначность
{
    string str = numberA.ToString();                 // перевод числа в строку

    Console.WriteLine(str[2]);                      // вывод значение под индексом 1

}
else
{
    Console.WriteLine("the number is incorrect");
} 
*/

