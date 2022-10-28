/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */
Console.Write ("Input number of elements in first measurement: ");
int n=CorrectNaturalNumber();
Console.Write ("Input number of elements in second measurement: ");
int m=CorrectNaturalNumber();
Console.Write ("Input number of elements in third measurement: ");
int k=CorrectNaturalNumber();
int [,,] matrix= new int[n,m,k];
FillWhithInt(matrix);
Console.WriteLine();
Console.WriteLine("Matrix: ");
//PrintArray(firstMatrix,0);
for (int i=0; i<matrix.GetLength(0);i++)
{
    for (int j=0; j<matrix.GetLength(1);j++)
    {
        for (int p=0; p<matrix.GetLength(2);p++)
            Console.Write ($" {matrix[j,p,i]} ({j},{p},{i}) ");
    Console.WriteLine();
    }
    
}            



void FillWhithInt(int[,,] array)                               //метод заполнения массива числами
{
    int value=10;
    for (int i=0; i<array.GetLength(0);i++)
        for (int j=0; j<array.GetLength(1);j++)
            for (int p=0; p<array.GetLength(2);p++)
            {
                array[i,j,p]=value;
                value++;
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
