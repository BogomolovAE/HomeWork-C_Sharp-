/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */
Console.Write("Insert coordinate x of point A (xa): ");
double xa=Convert.ToDouble(Console.ReadLine());
Console.Write("Insert coordinate y of point A (ya): ");
double ya=Convert.ToDouble(Console.ReadLine());
Console.Write("Insert coordinate z of point A (za): ");
double za=Convert.ToDouble(Console.ReadLine());
Console.Write("Insert coordinate x of point B (xb): ");
double xb=Convert.ToDouble(Console.ReadLine());
Console.Write("Insert coordinate y of point B (yb): ");
double yb=Convert.ToDouble(Console.ReadLine());
Console.Write("Insert coordinate z of point B (zb): ");
double zb=Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Ditance between points A and B is: {Math.Round(Math.Sqrt((xa-xb)*(xa-xb)+(ya-yb)*(ya-yb)+(za-zb)*(za-zb)), 2)}");