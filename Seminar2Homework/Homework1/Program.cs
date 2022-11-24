//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1


// Математическое решение

Console.Clear();
Console.WriteLine("Enter a three-digit number");

int numberA = Convert.ToInt32(Console.ReadLine());   //ввод числа с терминала

if ((numberA > 99) && (numberA < 1000))
{
    int numberTtree = numberA % 10;
    int numberOne = (numberA - numberTtree) / 10;
    int numberTwo = numberOne % 10;
    Console.WriteLine(numberTwo);
}
else
{
    Console.WriteLine("the number is incorrect");
}











//Решение через перевод в string

/* Console.Clear();
Console.WriteLine("Enter a three-digit number");
int numberA =Convert.ToInt32(Console.ReadLine());   //ввод числа с терминала
if ((numberA>99) && (numberA<1000))                 // проверка на трехзначность
{
   string str = numberA.ToString();                 // перевод числа в строку
    Console.WriteLine(str[1]);                      // вывод значение под индексом 1
}
else
{
Console.WriteLine("the number is incorrect");
} */
