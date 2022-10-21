/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */
int index=1;
int positiveQuantity=0;
Console.WriteLine ("If you want to exit programm, type \"exit\" ");
string numberInString="";
while (true)
{
    if (index==10) Console.WriteLine ("If you want to exit programm, type \"exit\" ");
    Console.Write($"Enter {index} number: ");
    numberInString=Console.ReadLine();
    if (numberInString.ToUpper()=="EXIT") break;
    try 
    {
        if (Double.Parse(numberInString)>0) positiveQuantity++;
    }
    catch 
    {
        Console.WriteLine ("ERROR! Check you string, it must be number!");
        continue;
    }
    index++;
}
if (positiveQuantity==0) Console.WriteLine ("There are no positive numbers in your list");
else if (positiveQuantity==1) Console.WriteLine ("There is 1 positive number in your list");
else Console.WriteLine($"There are {positiveQuantity} positive numbers in your list");