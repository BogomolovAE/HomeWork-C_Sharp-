/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */
m1:
Console.Write("Input number of week day (1..7): ");
string N=Console.ReadLine();
try{                                
Convert.ToInt32(N);                 //Блок проверки ввода числа а не строки
}
catch 
{
    Console.WriteLine ("You String is not a number, try again");
    goto m1;
}
while (Convert.ToInt32(N)<1||Convert.ToInt32(N)>8)
{
    Console.Write("There is no such day in week, try again (number must be between 1 and 7): ");
    N=Console.ReadLine();
    try{                                
Convert.ToInt32(N);                 //Блок проверки повторного ввода числа а не строки
}
catch 
{
    Console.WriteLine ("You String is not a number, try again");
    goto m1;
}
}
if (Convert.ToInt32(N)<6) Console.WriteLine (N + " is a weekday");
else Console.WriteLine (N + " is a weekend");