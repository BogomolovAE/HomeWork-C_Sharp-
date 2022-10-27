/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */
Console.Write ("Input quantity of lines: ");
int n=CorrectNaturalNumber();
Console.Write ("Input quantity of columns: ");
int m=CorrectNaturalNumber();
int [,] arrayOfInt= new int[n,m];
FillWhithInt(arrayOfInt);
Console.WriteLine();
PrintArray(arrayOfInt,0);
int minimalLineSum=0;
int numberOfLineWithMinimalSum=0;
bool newValueOfMinimalSum=true;
for (int i=0; i<arrayOfInt.GetLength(0);i++)
{
    int currentLineSum=0;
    for (int j=0; j<arrayOfInt.GetLength(1);j++)
    {
        currentLineSum+=arrayOfInt[i,j];
    }    
    if (newValueOfMinimalSum) 
    {
        minimalLineSum=currentLineSum;
        newValueOfMinimalSum=false;
    }
    if (currentLineSum<minimalLineSum)
    {
        minimalLineSum=currentLineSum;
        numberOfLineWithMinimalSum=i;
    }
}
Console.Write ($"Line number {numberOfLineWithMinimalSum} is line with minimal sum of elements");







void FillWhithInt(int[,] array)                               //метод заполнения массива случайными вещественными числами
{
    for (int i=0; i<array.GetLength(0);i++)
    for (int j=0; j<array.GetLength(1);j++)
        array[i,j]=new Random().Next(-100,100);
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
