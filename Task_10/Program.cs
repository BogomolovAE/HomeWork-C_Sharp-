/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */
Console.Write("Input number with three digits: ");
int N=Convert.ToInt32(Console.ReadLine());
while (N<100||N>999)
{
    Console.Write("The number must be with three digits: ");
    N=Convert.ToInt32(Console.ReadLine());
}
N=(N-100*(N/100)-N%10)/10;
Console.WriteLine ("The second digit of number N is: "+N);