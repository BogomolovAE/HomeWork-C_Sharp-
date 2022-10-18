/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
 */
int count=0;

RandomArray(10,100,999);
Console.WriteLine();
Console.WriteLine($" There are {count} even numbers in array");
int [] RandomArray(int numberOfElements,int min, int max)
{
    int [] arrayInInt = new int [new Random().Next(1,numberOfElements)];
    
    for (int i=0;i<arrayInInt.Length;i++)
    {
        arrayInInt[i]=new Random().Next(min,max);
        if (arrayInInt[i]%2==0) count++;
        Console.Write($"{arrayInInt[i]}"+new string(' ',2));
    }
    return arrayInInt;
}   