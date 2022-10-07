/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */
Console.Write("Input number: ");
string N=Console.ReadLine();
string Check (string N)                                                         // Процедура проверки значений введенной строки
{
    m1:
    try{                                
        Convert.ToInt32(N);                                                      //Блок проверки ввода числа а не строки
    }
    catch 
    {
        Console.Write ("You String is not a number, try again: ");
        N=Console.ReadLine();
        goto m1;
    }
    N=Convert.ToString(Math.Abs(Convert.ToInt32(N)));                           //Убираем нули и минусы вначале числа
    return N;
}
N=Check(N);
if (N.Length<3) Console.Write("There is no third digit in your number");
else Console.WriteLine ("The third digit of number N is: "+N[2]);
