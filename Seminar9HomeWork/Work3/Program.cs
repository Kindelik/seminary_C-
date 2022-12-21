// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

uint DataEntry(string messag)
{
    System.Console.Write($"{messag} => ");
    uint number = uint.Parse(Console.ReadLine());
    return number;
}

uint AckermanFunction(uint numberM, uint numberN)
{
    if (numberM == 0)
    {
        return numberN + 1;
    }
    else if ((numberM != 0) && (numberN == 0))
    {
        return AckermanFunction(numberM - 1, 1);
    }
    else
    {
        return AckermanFunction(numberM - 1, AckermanFunction(numberM, numberN - 1));
    }
}

uint numberM = DataEntry("Enter  first not a negative number");
uint numberN = DataEntry("Enter second not a negative number");
uint meaningAckerman = AckermanFunction(numberM, numberN);
System.Console.WriteLine($"Ackerman function for numbers ({numberM},{numberN}) = {meaningAckerman}");

//  при значениях ulong numberM >= 4 && numberN >= 1 уходит in Stack overflow
//                      numberM >= 3 && numberN >= 11
//                      numberM >= 2 && numberN >= 6888

//  при значениях uint numberM >= 4  &&  numberN >= 1   уходит in Stack overflow
//                     numberM >= 3  &&  numberN >= 12
//                     numberM >= 2 && numberN >= 9632