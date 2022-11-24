// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//  Если число 2 не кратно числу 1, то программа выводит остаток от деления.

//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно
Console.Clear();
Console.WriteLine("Enter numberA");
int numberA =int.Parse(Console.ReadLine());

Console.WriteLine("Enter numberB");
int numberB =int.Parse(Console.ReadLine());

if (numberB>numberA)

{
    if (numberB%numberA == 0)
   {
    Console.WriteLine($"{numberB} кратно {numberA}");
   }

     else
    {
    Console.WriteLine($"не кратно, остаток {numberB%numberA}");
    }
}

else
{
    Console.WriteLine("numbers incorrect, numberB > numberA");
}