/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */
string numInString="";
bool isError=true;
int sum=0;
while (isError)
{
    Console.Write("Input number: ");
    numInString=Console.ReadLine();
    try
    {
        int.Parse(numInString);
    }
    catch
    {
        Console.WriteLine("Error! You string is not a number");
        isError=true;
        continue;
    }
    isError=false;
}
for (int i=0; i<numInString.Length;i++) if (Char.IsDigit(numInString[i])) sum+=int.Parse(Convert.ToString(numInString[i]));
Console.WriteLine($"Summ of digits is: {sum}");