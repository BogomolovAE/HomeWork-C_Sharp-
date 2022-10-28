/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
А В
1 4 | 3 5
3 5 | 1 2
Результирующая матрица будет:
С
7 13
14 25
Произведением двух матриц А и В называется матрица С, элемент которой, находящийся на пересечении i-й строки и j-го столбца, равен сумме произведений элементов i-й строки матрицы А на соответствующие (по порядку) элементы j-го столбца матрицы В.
С (0,0) = А(0,0) * B(0,0) + A(0,1) * B(1,0) = 1 · 3 + 4 · 1 = 3 + 4 = 7
С (0,1) = А(0,0) * B(0,1) + A(0,1) * B(1,1) = 1 · 5 + 4 · 2 = 5 + 8 = 13
С (1,0) = А(1,0) * B(0,0) + A(1,1) * B(1,0) = 3 · 3 + 5 · 1 = 9 + 5 = 14
С (1,1) = А(1,0) * B(0,1) + A(1,1) * B(1,1) = 3 · 5 + 5 · 2 = 15 + 10 = 25
Произведение двух матриц АВ имеет смысл только в том случае, когда число столбцов матрицы А совпадает с числом строк матрицы В.
В произведении матриц АВ число строк равно числу строк матрицы А , а число столбцов равно числу столбцов матрицы В. */

Console.Write ("Input quantity of lines of first matrix: ");
int n=CorrectNaturalNumber();
Console.Write ("Input quantity of columns of first matrix: ");
int m=CorrectNaturalNumber();
int [,] firstMatrix= new int[n,m];
FillWhithInt(firstMatrix);
Console.WriteLine();
Console.WriteLine("First matrix: ");
PrintArray(firstMatrix,0);
Console.Write ("Input quantity of lines of second matrix: ");
int k=CorrectNaturalNumber();
Console.Write ("Input quantity of columns of second matrix: ");
int p=CorrectNaturalNumber();
int [,] secondMatrix= new int[k,p];
FillWhithInt(secondMatrix);
Console.WriteLine();
Console.WriteLine("Second matrix: ");
PrintArray(secondMatrix,0);
Console.WriteLine();

if (MultiplicationOfMatrix(firstMatrix,secondMatrix)!=null)
{
    Console.WriteLine("Multiplied matrix: ");
    PrintArray(MultiplicationOfMatrix(firstMatrix,secondMatrix),0);

}
int [,] MultiplicationOfMatrix(int [,] matrix1, int [,] matrix2)
{
    int [,] matrixMult= new int [matrix1.GetLength(0),matrix2.GetLength(1)];
    if (matrix1.GetLength(1)!=matrix2.GetLength(0))
    {
        Console.WriteLine("Matrixs can't be multiplied: ");
        return null;
    }
    
    for (int i=0;i<matrixMult.GetLength(0);i++)
    {
        for (int j=0;j<matrixMult.GetLength(0);j++)
        {
            for (int p=0;p<matrix1.GetLength(1);p++) matrixMult[i,j]+=matrix1[i,p]*matrix2[p,j];
        }
    }
    return matrixMult;
}



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