/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */
Console.Write ("Input quantity of lines: ");
int n=CorrectNaturalNumber();
Console.Write ("Input quantity of columns: ");
int m=CorrectNaturalNumber();
int [,] arrayOfInt= new int[n,m];
FillWhithDouble(arrayOfInt);
Console.WriteLine();
PrintArray(arrayOfInt);
Console.WriteLine();
Console.WriteLine ("Arithmetic means of columns: ");

for (int i=0; i<arrayOfInt.GetLength(0);i++)
{
    int summ=0;
    for (int j=0; j<arrayOfInt.GetLength(1);j++)
        summ+=arrayOfInt[j,i];

    Console.Write ($"  {Convert.ToDouble(summ)/n:f2}  ");
}

void FillWhithDouble(int[,] array)                               //метод заполнения массива случайными вещественными числами
{
    for (int i=0; i<array.GetLength(0);i++)
    for (int j=0; j<array.GetLength(1);j++)
        array[i,j]=new Random().Next(-100,100);
}

void PrintArray (int[,] array)                                   //метод вывода массива на экран
{
    for (int i=0; i<array.GetLength(0);i++)
    
    {
        for (int j=0; j<array.GetLength(1);j++)
        Console.Write($"  {array[i,j]}  ");
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
