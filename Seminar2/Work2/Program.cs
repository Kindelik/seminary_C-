//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

//456 -> 46
//782 -> 72
//918 -> 98

//int number = new Random().Next(100, 1000);   // не работает

//Console.WriteLine(number);
//var str = number.ToString();

//int number1 = int.Parse(str.Remove(str.Length - 1, 1));  // непонятная строка

//Console.WriteLine(number1);


Console.Clear();
int numberR = new Random().Next(100, 1000);

Console.WriteLine(numberR);

int numberR1 = ((numberR / 100) * 10) + (numberR % 10);

Console.WriteLine(numberR1);


