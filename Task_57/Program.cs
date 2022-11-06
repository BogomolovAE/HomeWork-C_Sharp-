/* Задача 57 Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
1, 2, 3
4, 6, 1
2, 1, 6

1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза */
/* Console.Write ("Input quantity of lines: ");
int n=CorrectNaturalNumber();
Console.Write ("Input quantity of columns: ");
int m=CorrectNaturalNumber(); */
//int [,] arrayOfInt= new int[n,m];
int [,] arrayOfInt= new int[,] {{1,2,3},{4,6,1},{2,1,6}};
int [,] numberFrequency = new int [2,arrayOfInt.GetLength(0)*arrayOfInt.GetLength(1)];          //двумерный массив первая строка - уникальные цифры, вторая строка - соответствующее число повторений
int uniqueValues=0;
//FillWhithInt(arrayOfInt);
Console.WriteLine();
PrintArray(arrayOfInt,1);
Console.WriteLine();
for (int i=0;i<arrayOfInt.GetLength(0);i++)
{
    for (int j=0;j<arrayOfInt.GetLength(1);j++)
    {
        AddNumber(numberFrequency,arrayOfInt[i,j]);
    }
}
Console.WriteLine("Numbers repeats: ");
for (int k=0;k<uniqueValues;k++)
{
    Console.WriteLine($"{numberFrequency[0,k]} : {numberFrequency[1,k]}");
}
void AddNumber (int [,] matrix, int number)
{
    bool newNumber = true;
    for (int p=0;p<uniqueValues;p++)
    {
        if (matrix[0,p]==number)
        {
           matrix[1,p]++;
           newNumber=false;
           break;
        }
    }
    if (newNumber)
    {
        matrix[0,uniqueValues]=number;
        matrix[1,uniqueValues]=1;
        uniqueValues++;
    }
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