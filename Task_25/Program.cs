/* int digits=6;
int [] number = new int [digits];
for (int i=0; i<=number.Length-1;i++) number[i]=new Random().Next(0,10);
 */
int [] firstArray= {4,3,4,6,5};
int [] secondArray= {3,5};

for (int i=0; i<firstArray.Length;i++) Console.Write($" {firstArray[i]} ");
Console.WriteLine();
for (int i=0; i<secondArray.Length;i++) Console.Write($" {secondArray[i]} ");
Console.WriteLine();
NumbersMult(firstArray, secondArray);

 void NumbersMult (int [] array1, int [] array2)
{
    int [] result=new int[(array1.Length+array2.Length+2)]; //по умолчанию инициализированы 0
    int [,] matrixForCount=new int [array2.Length,(array1.Length+array2.Length+2)]; //по умолчанию инициализированы 0
        int lines=0;
    
    for (int array2Index=array2.Length-1;array2Index>=0;array2Index--) //Цикл перебора массива, содержащего цифры второго числа
    {
        for (int array1Index=array1.Length-1;array1Index>=0;array1Index--) //Цикл перебора массива, содержащего цифры первого числа
        {
           matrixForCount[lines,array2.Length+2+array1Index-lines-1]=(matrixForCount[lines,array2.Length+2+array1Index-lines]+array1[array1Index]*array2[array2Index])/10; //получение десятичного остатка текущего разряда и перенос его в единицы следующего разряда
            matrixForCount[lines,array2.Length+2+array1Index-lines]=(matrixForCount[lines,array2.Length+2+array1Index-lines]+array1[array1Index]*array2[array2Index])%10; //запись единиц текущего разряда для array1
            
         }
        lines++;
    
    }
 //ВЫВОД matrixForCount
 for (int i=0;i<matrixForCount.GetLength(0);i++)
 {Console.WriteLine();
 for (int j=0;j<matrixForCount.GetLength(1);j++) Console.Write($"{matrixForCount[i,j]}");
 }
 Console.WriteLine(10/10);
 
 
 
 
 
    for (int resultIndex=array1.Length+array2.Length+2-1;resultIndex>=1;resultIndex--) //Цикл перебора столбцов матрицы matrixForCount
    {
        for (lines=0;lines<array2.Length;lines++)
        {
            result[resultIndex]+=matrixForCount[lines,resultIndex];          
        }
        result[resultIndex-1]=result[resultIndex]/10;
        result[resultIndex]=result[resultIndex]%10;
    }
    PrintArray(result);

}
void PrintArray(int [] arrayForPrint)
{
     Console.WriteLine();
    Console.WriteLine ("Multiplied Array: ");
    for (int i=0;i<arrayForPrint.Length;i++)
    {
        Console.Write($"{arrayForPrint[i]}");
      //  for (int j=0;arrayForPrint.GetLength(i);j++) Console.Write($"{arrayForPrint[i,j]}");
        

    }

} 

/* Console.WriteLine();
for (int i=0; i<=number.Length-1;i++) Console.Write($" {number[i]} "); */