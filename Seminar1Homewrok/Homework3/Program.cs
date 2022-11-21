//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//Примеры
//4 -> да
//-3 -> нет
//7 -> нет

Console.Clear();
Console.WriteLine("Enter a number");
int number = int.Parse(Console.ReadLine());
if(number%2 ==0) Console.WriteLine("Число четное");
else Console.WriteLine("Число нечетное");