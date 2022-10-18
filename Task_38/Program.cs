/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

bool newMin=true;
bool newMax=true;
double maxVal=0;
double minVal=0;
double [] RandomArray(int numberOfElements,int min, int max)
{
    double [] arrayInDbl = new double [new Random().Next(1,numberOfElements)];
    
    for (int i=0;i<arrayInDbl.Length;i++)
    {
        arrayInDbl[i]=Convert.ToDouble((new Random().Next(min*100,max*100)))/1000;
        if (newMax) 
        {
            maxVal=arrayInDbl[i];
            newMax=false;
        }
        else if (maxVal<arrayInDbl[i]) maxVal=arrayInDbl[i];
        if (newMin) 
        {
            minVal=arrayInDbl[i];
            newMin=false;
        }
        else if (minVal>arrayInDbl[i]) minVal=arrayInDbl[i];
        Console.Write($"{arrayInDbl[i]}"+new string(' ',2));
    }
    return arrayInDbl;
}
RandomArray(20,-100, 100);
Console.WriteLine();
Console.WriteLine($"min={minVal}    max={maxVal}    max-min={maxVal-minVal:f4}");