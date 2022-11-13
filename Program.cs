	/*
 Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double MyPow(double A, int B)
{
    double DegreeA = A;
    int Count = 1;
    if(A == 0)
        DegreeA = 0;
    else if (A == 1)
        DegreeA = 1;
    else if(B == 0)    
        DegreeA = 1;
    else if (B == 1)
        DegreeA = A;
    else
        while(Count != B)
        {
            DegreeA *= A;
            Count ++;
        }
    return DegreeA;    
}
Console.WriteLine("Input nunber A");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input nunber B");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"nunber A to the B power is: {MyPow(a, b)}");
*/
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
/*
int SummDigitNumber(int number)
{
    int sumdigit = 0;
    while(number > 0)
    {
        sumdigit = sumdigit + (number % 10);
        number = number / 10;
    }
    return sumdigit;
}
Console.WriteLine("Input your number");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The Sum of all digit number: {SummDigitNumber(num)}");
*/
/*Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
int[] InputedArray(int size)
{
   int[] array = new int [size];      
   for(int i = 0; i < size; i++)
        array[i] = Convert.ToInt32(Console.ReadLine());
    return array;      
}
void ShowArray(int[] array)
{       
    Console.WriteLine("Your Array:");
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}
Console.WriteLine("Input size of your array");
int sizeA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input elements of your array");
int[] myInputedArray = InputedArray(sizeA);
ShowArray(myInputedArray);*/