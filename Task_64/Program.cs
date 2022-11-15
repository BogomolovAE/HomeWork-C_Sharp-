/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.Write ("Insert N: ");
int n=CorrectNaturalNumber();
PrintFromNTo1(n);
Console.WriteLine();
PrintFrom1ToN(n);

void PrintFromNTo1(int number)// Рекурсия для печати от N до 1
{
    Console.Write($" {number} ");
    if (number ==1) return;
    else  PrintFromNTo1(number-1);
}
void PrintFrom1ToN(int number) // Рекурсия для печати от 1 до N
{
    if (number ==1) 
    {
        Console.Write($" {number} ");
        return;
    }
    else  
    {
        PrintFrom1ToN(number-1);
        Console.Write($" {number} ");
    }
}

int CorrectNaturalNumber()                                       //метод проверки размерности массива
{
    string value="";
    int number=0;
    while (true)
    {
        value=Console.ReadLine();
        try 
        {
            number=int.Parse(value);
        }
        catch
        {
            Console.Write ("ERROR! Your string is not a decimal number, try again: ");
            continue;
        }
        if (number<1) 
        {
            Console.Write ("ERROR! Your number is less than 1, try again: ");
            continue;
        }
        return number;
    }
} 
