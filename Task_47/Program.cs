/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */
Console.Write ("Input number of lines: ");
int n=CorrectNaturalNumber();
Console.Write ("Input number of columns: ");
int m=CorrectNaturalNumber();
double [,] arrayOfDouble= new double[n,m];
FillWhithDouble(arrayOfDouble);
PrintArray(arrayOfDouble);

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








int CorrectNaturalNumber()
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
