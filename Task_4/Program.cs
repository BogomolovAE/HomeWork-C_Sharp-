/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */
int index=0;
int [] myArray = new int [3];
int max=0;
while (index<3)
{
    Console.WriteLine("Insert number № "+(index+1));
    myArray[index]=Convert.ToInt32(Console.ReadLine());
    if (index==0) max=myArray[index];
    else if (myArray[index]>max) max=myArray[index];
    index++;
}
Console.WriteLine ("Maximum is: "+max);
