/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
 */

int [] arrayInInt = new int [new Random().Next(1,10)];
int count=0;
for (int i=0;i<arrayInInt.Length;i++)
{
    arrayInInt[i]=new Random().Next(100,999);
    if (arrayInInt[i]%2==0) count ++;
    Console.Write($"{arrayInInt[i]}"+new string(' ',2));
}
Console.WriteLine();
Console.WriteLine($" There are {count} even numbers in array");
   