/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */
//                                                                      Решение рекурсией
int [,] spiralMatrix = new int [4,4];
int n=1;
int firstX=0;
int firstY=0;
int xStep=1;
int yStep=0;
int stepDirection=0;
SpiralFilled (spiralMatrix,firstX,firstY,n);
Console.WriteLine("Task solution with recursion:");
PrintArray (spiralMatrix,1);

void SpiralFilled (int [,] matrix, int x, int y, int n)
{
    matrix[y,x]=n;
    if ((y==0)&&(x==matrix.GetLength(1)-1)) stepDirection++;
    else if ((y==matrix.GetLength(0)-1)&&(x==matrix.GetLength(1)-1)) stepDirection++;
    else if ((y==matrix.GetLength(0)-1)&&(x==0)) stepDirection++;
    else if(matrix[y+yStep,x+xStep]!=0) stepDirection++;
    if (stepDirection>3) stepDirection=0;
    switch (stepDirection)
    {
        case 0: xStep=1; yStep=0; break;
        case 1: xStep=0; yStep=1; break;
        case 2: xStep=-1; yStep=0; break;
        case 3: xStep=0; yStep=-1; break;
    }    
    if (matrix[y+yStep,x+xStep]!=0) return ;
    else SpiralFilled (matrix,x+xStep,y+yStep,n+1);
} 
//                                                                      Решение циклом                                            
Console.WriteLine();
Console.WriteLine("Task solution with cycle:");
int [,] spiralMatrixCycle = new int [4,4];
int nCycle=1;
int xPosition=0;
int yPosition=0;
int xStepCycle=1;
int yStepCycle=0;
int stepDirectionCycle=0;
while (true)
{
    spiralMatrixCycle[yPosition,xPosition]=nCycle;
    if ((yPosition==0)&&(xPosition==spiralMatrixCycle.GetLength(1)-1)) stepDirectionCycle++;
    else if ((yPosition==spiralMatrixCycle.GetLength(0)-1)&&(xPosition==spiralMatrixCycle.GetLength(1)-1)) stepDirectionCycle++;
    else if ((yPosition==spiralMatrixCycle.GetLength(0)-1)&&(xPosition==0)) stepDirectionCycle++;
    else if(spiralMatrixCycle[yPosition+yStepCycle,xPosition+xStepCycle]!=0) stepDirectionCycle++;
    if (stepDirectionCycle>3) stepDirectionCycle=0;
    switch (stepDirectionCycle)
    {
        case 0: xStepCycle=1; yStepCycle=0; break;
        case 1: xStepCycle=0; yStepCycle=1; break;
        case 2: xStepCycle=-1; yStepCycle=0; break;
        case 3: xStepCycle=0; yStepCycle=-1; break;
    }    
    if (spiralMatrixCycle[yPosition+yStepCycle,xPosition+xStepCycle]!=0) break ;
    xPosition+=xStepCycle;
    yPosition+=yStepCycle;
    nCycle++;
}
PrintArray (spiralMatrix,1);


int NumberLength (int a)                                         // метод определения количества символов в числе (для целых чисел)
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
            if (NumberLength(array[i,j])>maxSymbolElement) maxSymbolElement=NumberLength(array[i,j]);
        }
    }
    maxSymbolElement+=emptysymbols;                             //добавление пустых элементов для настройки ширины столбца
    for (int i=0; i<array.GetLength(0);i++)                     //вывод элементов массива на экран
    {
        for (int j=0; j<array.GetLength(1);j++)
        Console.Write($"|{new string(' ',(maxSymbolElement-NumberLength(array[i,j]))/2)}{array[i,j]}{new string(' ',maxSymbolElement-(maxSymbolElement-NumberLength(array[i,j]))/2-NumberLength(array[i,j]))}");
        Console.WriteLine("|");
    }
}
