/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
Задача 54.1 : Задайте двумерный массив. Напишите программу, которая упорядочит элементы по убыванию (или возрастанию). */

Console.Write ("Input quantity of lines: ");
int n=CorrectNaturalNumber();
Console.Write ("Input quantity of columns: ");
int m=CorrectNaturalNumber();
int [,] arrayOfInt= new int[n,m];
FillWhithInt(arrayOfInt);
Console.WriteLine();
PrintArray(arrayOfInt,0);
Console.WriteLine("Sorted by line matrix: ");
SortByLine(arrayOfInt);
PrintArray(arrayOfInt,0);
Console.WriteLine("Sorted matrix: ");
ReverseSort(arrayOfInt);
PrintArray(arrayOfInt,0);


void SortByLine (int[,] array)   
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        int temp=0;
        if (array.GetLength(1)>1)
        {
            for (int j=0;j<array.GetLength(1);j++) 
            {
                for (int k=0;k<array.GetLength(1)-1;k++)
                    {
                        if (array[i,k]<array[i,k+1])
                        {
                            temp=array[i,k];
                            array[i,k]=array[i,k+1];
                            array[i,k+1]= temp;
                        }
                    }
            }
      }
    }
}



void ReverseSort (int[,] array)                     //Сортировка по убыванию методом "поиск макисмального значения"
{
    int maxLine=0;
    int maxColumn=0;
    int max=array[maxLine,maxColumn];
    for (int i=0; i<array.GetLength(0);i++)
    for (int j=0; j<array.GetLength(1);j++)
    {
        int temp=0;
        max=array[i,j];
        maxLine=i;
        maxColumn=j;
        int startSearch=j;
        for (int iInner=i; iInner<array.GetLength(0);iInner++)
        {
            for (int jInner=startSearch; jInner<array.GetLength(1);jInner++)
            {
                if(max<array[iInner,jInner])
                {
                    max=array[iInner,jInner];
                    maxLine=iInner;
                    maxColumn=jInner;
                }
            }  
            startSearch=0;
        }
        temp=array[i,j];
        array[i,j]=array[maxLine,maxColumn];
        array[maxLine,maxColumn]=temp;
    }
}
void FillWhithInt(int[,] array)                               //метод заполнения массива случайными вещественными числами
{
    for (int i=0; i<array.GetLength(0);i++)
    for (int j=0; j<array.GetLength(1);j++)
        array[i,j]=new Random().Next(-100,100);
}
int NumberLenth (int a)                                         // метод определения количества символов в числе (для целых чисел)
{
    int temp=0;
    for (int h=Math.Abs(a);h>0;h/=10) temp++;
    if (a<0) temp++;
    return temp;
}
void PrintArray (int[,] array, int emptysymbols)                 //метод вывода массива на экран
{
    int maxSymbolElement=0;
    for (int i=0; i<array.GetLength(0);i++)                     //определение элемента с максимальной количеством символов
    {
        for (int j=0; j<array.GetLength(1);j++)
        {
            if (NumberLenth(array[i,j])>maxSymbolElement) maxSymbolElement=NumberLenth(array[i,j]);
        }
    }
    maxSymbolElement+=emptysymbols;                             //добавление пустых элементов для настройки ширины столбца
    for (int i=0; i<array.GetLength(0);i++)                     //вывод элементов массива на экран
    {
        for (int j=0; j<array.GetLength(1);j++)
        Console.Write($"|{new string(' ',(maxSymbolElement-NumberLenth(array[i,j]))/2)}{array[i,j]}{new string(' ',maxSymbolElement-(maxSymbolElement-NumberLenth(array[i,j]))/2-NumberLenth(array[i,j]))}");
        Console.WriteLine("|");
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