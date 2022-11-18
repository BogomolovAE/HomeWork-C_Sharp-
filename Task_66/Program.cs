/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
Console.Write("Insert M:");
int m=CorrectNaturalNumber();
Console.Write("Insert N:");
int n=CorrectNaturalNumber();
if (m>n)
{
    int temp=n;
    n=m;
    m=temp;
}


int SumRecursion(int m1,int n1)
{
    if (m1==n1) return n1;
    else
    {
        return SumRecursion(m1+1, n1)+m1;
        
    }
}
Console.WriteLine ($"Summ = {SumRecursion(m,n)}");




int CorrectNaturalNumber()                                       //метод проверки размерности массива
{
    string value="";
    int number=0;
    while (true)
    {
        value=Console.ReadLine();
        try 
        {
            number=int.Parse(value);
        }
        catch
        {
            Console.Write ("ERROR! Your string is not a decimal number, try again: ");
            continue;
        }
        if (number<1) 
        {
            Console.Write ("ERROR! Your number is less than 1, try again: ");
            continue;
        }
        return number;
    }
} 
