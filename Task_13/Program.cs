/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */
m1:
Console.Write("Input number: ");
string N=Console.ReadLine();
try{                                
Convert.ToInt32(N);                 //Блок проверки ввода числа а не строки
}
catch 
{
    Console.WriteLine ("You String is not a number");
    goto m1;
}
if (N.Length<3) Console.Write("There is no third digit in your number");
else Console.WriteLine ("The third digit of number N is: "+N[2]);
