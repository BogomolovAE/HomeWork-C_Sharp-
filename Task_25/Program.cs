
/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.Write("Input first number: ");
number firstNumber=new number (Console.ReadLine()); 
bool checkPassed=false;
int secondNumber;
string secondNumberinString="";
while (!checkPassed)
{
    Console.Write("Input second number: ");
    secondNumberinString=Console.ReadLine(); 
 try
{   
    Int32.Parse(secondNumberinString);
}
catch
{
    Console.WriteLine("Error: second number must be natural! ");
    checkPassed=false;
    continue;
}
break;
}
secondNumber=Int32.Parse(secondNumberinString);
number result= new number(); // создание переменной number с использованием конструктора по умолчанию
result=firstNumber;
//****************************************************************БЛОК ВЫЧИСЛЕНИЙ**********************************************************************
for (int i=2;i<=secondNumber;i++)
{
    result=NumbersMult(result,firstNumber);
} 
Console.WriteLine($"Result is: {result.NumberInString}");
number NumbersMult(number Num1,number Num2 )                                                    //Функция 
{
    int [] result=new int[(Num1.NumberInIntArray.Length+Num2.NumberInIntArray.Length)];       //По умолчанию инициализированы 0
    int [,] matrixForCount=new int [Num2.NumberInIntArray.Length,(Num1.NumberInIntArray.Length+Num2.NumberInIntArray.Length)];   //По умолчанию инициализированы 0
        int lines=0;
    
    for (int num2Index=Num2.NumberInIntArray.Length-1;num2Index>=0;num2Index--)              //Цикл перебора массива, содержащего цифры второго числа
    {
        for (int num1Index=Num1.NumberInIntArray.Length-1;num1Index>=0;num1Index--)          //Цикл перебора массива, содержащего цифры первого числа
        {
            matrixForCount[lines,Num2.NumberInIntArray.Length+num1Index-lines-1]=(matrixForCount[lines,Num2.NumberInIntArray.Length+num1Index-lines]+Num1.NumberInIntArray[num1Index]*Num2.NumberInIntArray[num2Index])/10; //получение десятичного остатка текущего разряда и перенос его в единицы следующего разряда
            matrixForCount[lines,Num2.NumberInIntArray.Length+num1Index-lines]=(matrixForCount[lines,Num2.NumberInIntArray.Length+num1Index-lines]+Num1.NumberInIntArray[num1Index]*Num2.NumberInIntArray[num2Index])%10; //запись единиц текущего разряда для Num1.NumberInIntArray
        }
        lines++;
    }
/*  //ВЫВОД matrixForCount
    for (int i=0;i<matrixForCount.GetLength(0);i++)
    {Console.WriteLine();
        for (int j=0;j<matrixForCount.GetLength(1);j++) Console.Write($"{matrixForCount[i,j]}");
    } */
//Сложение в matrixForCount 
    for (int resultIndex=Num1.NumberInIntArray.Length+Num2.NumberInIntArray.Length-1;resultIndex>=0;resultIndex--) //Цикл перебора столбцов матрицы matrixForCount
    {
        for (lines=0;lines<Num2.NumberInIntArray.Length;lines++)
        {
            result[resultIndex]+=matrixForCount[lines,resultIndex];          
        }
        if (resultIndex>0) result[resultIndex-1]=result[resultIndex]/10;
        result[resultIndex]=result[resultIndex]%10;
    }
//Удаление лишних нулей слева    
    int zeroQuantityInResult=0;
    for (int i=0; i<result.Length;i++) 
    if (result[i]==0) zeroQuantityInResult++;
    else break;
    if (zeroQuantityInResult>0)
    { 
        int [] tempararyArray=new int [result.Length-zeroQuantityInResult];
        Array.Reverse(result);
        Array.Copy(result,tempararyArray,result.Length-zeroQuantityInResult);
        Array.Resize(ref result,result.Length-zeroQuantityInResult);
        Array.Reverse(tempararyArray);
        Array.Copy(tempararyArray,result,result.Length);
    }
    number result1=new number(Num1.Negative^Num2.Negative,Num1.DigitsAfterPoint+Num2.DigitsAfterPoint,result);
    return result1;

} 
//****************************************************************БЛОК ПОДГОТОВКИ ФОРМАТОВ*************************************************************
struct number
{
    private bool negative;                                         //Знак числа
    private int pointBeforePosition;                               //Индекс элемента перед которым стоит разделитель
    private string numberInString;                                 //Значение числа в строковом формате 
    private bool isError;                                          //Наличие ошибки
    private string errorMessage;                                   //Текст ошибки
    private int [] numberInIntArray = new int [1];                  //Представление числа в формате массива
    private char decimalSymbol;                                    //Вид символа для представления десятичного разделителя
     private int digitsAfterPoint;
//Методы доступа к значениям свойств
    public bool Negative 
        {get {return negative;}}
    public int DigitsAfterPoint 
        {get {return digitsAfterPoint;}}
    public string NumberInString
        {get {return numberInString;}}
    public int [] NumberInIntArray
        {get {return numberInIntArray;}}
        
 //Описание конструктора
    public number (string NIV)
    {
        negative=false;
        pointBeforePosition=-1;
        numberInString=NIV;
        isError = false;
        numberInIntArray[0]=0;
        errorMessage="";
        decimalSymbol='\0';
        digitsAfterPoint=-1;
        NumberAnalize (numberInString);
        while (isError)
        {
            isError = false;
            Console.WriteLine("Error: " + errorMessage);
            Console.Write("Input first number: ");
            numberInString=Console.ReadLine(); 
            NumberAnalize (numberInString);
        }
        NumberConvert (numberInString);
   
    }
    
    public number (bool Negative,int DigitsAfterPoint, int[] NIIA)
    {
        negative=Negative;
        digitsAfterPoint=DigitsAfterPoint;
        isError = false;
        Array.Resize (ref numberInIntArray, NIIA.Length);               //Расширение массива для хранения числа в int
        NIIA.CopyTo(numberInIntArray,0);                                //Копирование массива результата в массив для хранения числа в int
        errorMessage="";
        decimalSymbol=',';
        numberInString="";
        pointBeforePosition=-1;                                     
        StringConvert();
          
        //if (!isError) NumberConvert (numberInString);
        //else Console.WriteLine("Error: " + errorMessage);
    }
//Преобразование массива чисел в строку
    private void StringConvert()
    {
        if (negative) numberInString="-";
        if (digitsAfterPoint>0) numberInString+="0"+Convert.ToString(decimalSymbol)+new string('0',digitsAfterPoint-1);
        for (int i=0;i<numberInIntArray.Length;i++) numberInString+=Convert.ToString(numberInIntArray[i]);
        
    }
    private void NumberAnalize (string NIV)
    {
        int zeroQuantity=0;
        NIV.Trim();                                                 //Удаление пробелов из строки
//Первая половина строки определение знака, целостности (при нулевой целой части)
        while ((NIV[zeroQuantity]=='0'|| NIV[zeroQuantity]=='-'|| NIV[zeroQuantity]==',' || NIV[zeroQuantity]=='.')&&( pointBeforePosition==-1))  
        {
            switch(NIV[zeroQuantity])
            {
                case '-': negative=!negative; break;
                case ',': { decimalSymbol = ',' ; pointBeforePosition= zeroQuantity+1; } break;
                case '.': { decimalSymbol = '.' ; pointBeforePosition= zeroQuantity+1; } break;
            }
            zeroQuantity++;
        }
        for (int i= zeroQuantity;i<NIV.Length;i++)
        {

            if ((NIV[i]==','||NIV[i]=='.')&&( pointBeforePosition==-1)) 
            {
                if (NIV[i]==',') decimalSymbol = ',';
                else decimalSymbol = '.' ;
                pointBeforePosition=i;
                continue;
            }
            else if ((NIV[i]==decimalSymbol)&&( pointBeforePosition!=-1))
            {
                isError = true;
                errorMessage="your string contain more than one Decimal Symbol";
                break;
            }
            try
            {
                int.Parse (Convert.ToString(NIV[i]));
            }
            catch
            {
                isError = true;
                errorMessage="your string contains forbidden symbols";
                break;
            }
        }
// Изменение формата строки (удаление лишних нулей, удаление запятых, занимающих крайние позиции)
        if (pointBeforePosition!=-1) pointBeforePosition-=zeroQuantity;
        NIV=NIV.Remove(0, zeroQuantity); //Обрезание слева
        zeroQuantity=0;
        if (pointBeforePosition!=-1)
        for (int i=NIV.Length-1; i>=0; i--)
        {
            if (NIV[i]=='0') zeroQuantity++;
            else if (NIV[i]==decimalSymbol)
            {
                decimalSymbol='\0';
                pointBeforePosition=-1;
                zeroQuantity++;
            }
            else break;
        }
        if (zeroQuantity>0) NIV=NIV.Remove(NIV.Length- zeroQuantity, zeroQuantity); //Обрезание справа
        numberInString=NIV;
        if (decimalSymbol!='\0') digitsAfterPoint=numberInString.Length-1-numberInString.IndexOf(decimalSymbol);
        else digitsAfterPoint=0;
    }
// Преобразование отформатированной строки в массив чисел
    private void NumberConvert (string NIV)
    {
        Array.Resize (ref numberInIntArray, NIV.Length);
        int displacement =0;
        for (int i=0; i<numberInIntArray.Length;i++)
            {
                if (NIV[i]== decimalSymbol) displacement=1;
                numberInIntArray[i]=int.Parse(Convert.ToString(NIV[i+displacement]));
            }
    }
}