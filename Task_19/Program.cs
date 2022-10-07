/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */
//                              VARIANT 1 (WHITH LONGINT)
Console.WriteLine("Enter a number: ");
string numberInString=Console.ReadLine();
 string Check (string N)                                         // Процедура проверки значений введенной строки
{
    m1:
    while (N=="")
    {
        Console.Write("Your String is empty, try again: ");     // Проверка ввода пустой строки
        N=Console.ReadLine();
    }
  
    try{                                
        Convert.ToInt64(N);                                     //Блок проверки ввода строки а не числа
    }
    catch (FormatException)
    {
        Console.Write ("You String is not a number, try again: ");
        N=Console.ReadLine();
        goto m1;
    }
    catch (OverflowException)                                   //Блок проверки переполнения типа int при конвертировании строки
    
    {
      Console.Write ("You number, try again (number must be between –9 223 372 036 854 775 808 and 9 223 372 036 854 775 807): ");  
      N=Console.ReadLine();
      goto m1;
    }
    return N;
}
long number = Convert.ToInt64(Check(numberInString));
while (number/10>0)
{
    int numberOfDigits=Convert.ToInt32(Math.Ceiling(Math.Log10(number)));  //метод Math.Celling - для округления в большую сторону
    long tenPower=Convert.ToInt64(Math.Pow(10,numberOfDigits-1));
    if (number%10!=(number/tenPower)) break;
    number=(number-tenPower*(number/tenPower)-number%10)/10;
   }
if (number==0||number/10==0) Console.WriteLine("Polynome");
else Console.WriteLine("Not polynome");
