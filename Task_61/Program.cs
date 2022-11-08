/* Задача 61 Вывести первые N строк треугольника Паскаля.
Сделать вывод в виде равнобедренного треугольника

........1
......1 1
....1 2 1
..1 3 3 1
.1 4 6 4 1

Точки в началах строк в примере решения проставлены, так как редактор игнорирует пробелы в начале строки и выравнивает строки по левому краю.
Треугольник становится не равнобедренным, а прямоугольным.
В своем варианте решения попробуйте вывести равнобедренный треугольник без дополнительных точек. */
Console.Write("Insert number of lines in Pascal triangle: ");
int n=CorrectNaturalNumber() ;
int [,] pascalTriangle = new int [n,2*n+2];
pascalTriangle[0,pascalTriangle.GetLength(1)/2]=1;
for (int i=1;i<pascalTriangle.GetLength(0);i++)
{
    for (int j=0;j<pascalTriangle.GetLength(1);j++)
    {
        if (j>0&&j<pascalTriangle.GetLength(1)-1) {pascalTriangle[i,j]=pascalTriangle[i-1,j-1]+pascalTriangle[i-1,j+1];}
    }
}
PrintArray(pascalTriangle,1);
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
        {
            if (array[i,j]==0)//j>0&&array[i,j]==0&&array[i,j-1]>0)
            {
                Console.Write($"{new string(' ',(maxSymbolElement-NumberLength(array[i,j]))/2)}{" "}{new string(' ',maxSymbolElement-(maxSymbolElement-NumberLength(array[i,j]))/2-NumberLength(array[i,j]))}");
                    
            }
            else
            {
                Console.Write($"{new string(' ',(maxSymbolElement-NumberLength(array[i,j]))/2)}{array[i,j]}{new string(' ',maxSymbolElement-(maxSymbolElement-NumberLength(array[i,j]))/2-NumberLength(array[i,j]))}");
            }
        
        
        }
        Console.WriteLine();
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

