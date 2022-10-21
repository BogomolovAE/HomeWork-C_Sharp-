/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5 )*/
double k1=0;
double b1=0;
double k2=0;
double b2=0;
double CorrectInput()
{
    double variable=0;
    while (true)
    {
        try
        {
            variable=double.Parse(Console.ReadLine());
        }
        catch 
        {
            Console.Write ("ERROR! Your string is not a number, check it and try again!: ");
            continue;
        }
     return variable;
     } 
   
}
Console.Write ($"Input {nameof(k1)} : "); 
k1=CorrectInput();
Console.Write ($"Input {nameof(b1)} : "); 
b1=CorrectInput();
Console.Write ($"Input {nameof(k2)} : "); 
k2=CorrectInput();
Console.Write ($"Input {nameof(b2)} : "); 
b2=CorrectInput();
string b1Sign="+";
string b2Sign="+";
if (b1<0) b1Sign="-";
else if(b1==0) b1Sign="";
if (b2<0) b2Sign="-";
else if(b2==0) b2Sign="";
if (k1==k2) Console.WriteLine("Lines are parallel");
else Console.WriteLine($"Line \"y={k1}x{b1Sign}({b1})\" cross line  \"y={k2}x{b1Sign}({b2})\" at point [{(b1-b2)/(k2-k1):f2};{k1*(b1-b2)/(k2-k1)+b1:f2}]");
