/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */
Console.Write ("Input quantity of lines: ");
int n=CorrectNaturalNumber();
Console.Write ("Input quantity of columns: ");
int m=CorrectNaturalNumber();
double [,] arrayOfDouble= new double[n,m];
FillWhithDouble(arrayOfDouble);
Console.WriteLine();
PrintArray(arrayOfDouble);
Console.WriteLine();
Console.WriteLine ("Input position of element: ");

Console.Write ("Input number of line: ");
int line=CorrectNaturalNumber();
Console.Write ("Input number of column: ");
int column=CorrectNaturalNumber();
try
{
    Console.WriteLine($"Element [{line},{column}] is: {arrayOfDouble[line,column]:f4}");
}
catch
{
    Console.WriteLine($"Element [{line},{column}] doesn't exist");
}



void FillWhithDouble(double[,] array)                               //метод заполнения массива случайными вещественными числами
{
    for (int i=0; i<array.GetLength(0);i++)
    for (int j=0; j<array.GetLength(1);j++)
        array[i,j]=new Random().NextDouble();
}

void PrintArray (double[,] array)                                   //метод вывода массива на экран
{
    for (int i=0; i<array.GetLength(0);i++)
    
    {
        for (int j=0; j<array.GetLength(1);j++)
        Console.Write($"  {array[i,j]:f4}  ");
        Console.WriteLine();
    }
}

int CorrectNaturalNumber()                                          //метод проверки размерности массива
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
