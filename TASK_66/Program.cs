/*
Задача 66: 
Задайте значения M и N. 
Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


int SumElementMN(int numberM, int numberN)
{
    if (numberM > numberN)
    {
        return 0;
    }
    else
    {

        return SumElementMN(numberM + 1, numberN) + numberM;
    }
}
System.Console.WriteLine(SumElementMN(1, 15));
