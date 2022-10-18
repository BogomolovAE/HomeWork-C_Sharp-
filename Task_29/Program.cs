/* Задача 29: Напишите программу, которая задаёт массив произвольной длины, заполняет произвольными элементами и выводит их на экран.
Длину массива и элементы массива можно задать рандомно или попросить пользователя ввести в консоли.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */

int [] arrayInInt = new int [new Random().Next(1,10)];
bool maxNew=true;
int max=0;
for (int i=0;i<arrayInInt.Length;i++)
{
    arrayInInt[i]=new Random().Next(-1000,1000);
    if (maxNew)
    {
        max=arrayInInt[i];
        maxNew=false;
    }
}
    for (int i=0;i<arrayInInt.Length;i++)
    {
        Console.Write($"{arrayInInt[i]}"+new string(' ',2));
    }

 