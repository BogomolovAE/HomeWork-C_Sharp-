/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */
Console.Write("Insert number: ");
int N=Convert.ToInt32(Console.ReadLine());
if (N%2==0) Console.WriteLine ("Entered number is even");
else Console.WriteLine ("Entered number is odd");