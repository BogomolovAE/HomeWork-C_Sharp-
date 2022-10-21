/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */
int summOfNotEven=0;
int [] RandomArray(int numberOfElements,int min, int max)
{
    int [] arrayInInt = new int [new Random().Next(1,numberOfElements)];
    
    for (int i=0;i<arrayInInt.Length;i++)
    {
        arrayInInt[i]=new Random().Next(min,max);
        Console.Write($"{arrayInInt[i]}"+new string(' ',2));
        if (i%2!=0)summOfNotEven+=arrayInInt[i];
    }
    return arrayInInt;
}
RandomArray(10,-100,100);
Console.WriteLine();
Console.WriteLine($"Summ of not even number: {summOfNotEven}");
