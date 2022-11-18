/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */
Console.Write("Insert M:");
int m=CorrectNaturalNumber();
Console.Write("Insert N:");
int n=CorrectNaturalNumber();


int AkkermanFunction (int m1,int n1)
{
    if (m1==0) return n1+1;
    if (m1>0&&n1==0) return AkkermanFunction(m1-1,1);
    if (m1>0&&n1>0) return AkkermanFunction(m1-1,AkkermanFunction(m1,n1-1));
    else return 0;
}
Console.WriteLine ($"A({m},{n}) = {AkkermanFunction(m,n)}");
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
