/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

Console.Write("Input number of week day (1..7): ");
string N=Console.ReadLine();

string Check (string N)                                         // Процедура проверки значений введенной строки
{
    m1:
    while (N=="")
    {
        Console.Write("Your String is empty, try again: ");     // Проверка ввода пустой строки
        N=Console.ReadLine();
    }
  
    try{                                
        Convert.ToInt32(N);                                     //Блок проверки ввода строки а не числа
    }
    catch 
    {
        Console.Write ("You String is not a number, try again: ");
        N=Console.ReadLine();
        goto m1;
    }
    return N;
}
N=Check(N);
while (Convert.ToInt32(N)<1||Convert.ToInt32(N)>7)
{
    Console.Write("There is no such day in week, try again (number must be between 1 and 7): ");
    N=Console.ReadLine();
    N=Check(N);
}
if (Convert.ToInt32(N)<6) Console.WriteLine (N + " is a weekday");
else Console.WriteLine (N + " is a weekend");