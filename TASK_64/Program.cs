/*
Задача 64: 
Задайте значения M и N. 
Напишите программу, которая выведет все 
натуральные числа в промежутке от M до N.
M = 5; N = 1. -> "5, 4, 3, 2, 1"
M = 8; N = 4. -> "8, 7,6, 5, 4"
*/

void NuturalNumberMN(int numberM, int numberN)
{
    if (numberM < numberN)
    {
        return;
    }
    else
    {
        if (numberM >= numberN)
        {
            System.Console.Write(numberM);
            if (numberN < numberM)
            {
                System.Console.Write(", ");
            }
        }
        NuturalNumberMN(numberM - 1, numberN);

    }
}
NuturalNumberMN(8, 4);