Console.Clear();

// //Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
// //Method
// double FindPower(double A, int B)
// {
//     double C=1;
//     for(int i=1;i<=B;i++)
//     {
//         C=C*A;
//     }
//     return C;
// }

// //Initial data
// Console.WriteLine("Input first number");
// double num = Convert.ToDouble(Console.ReadLine());

// int ERR=1;
// int power=0;
// while (ERR==1)
// {
//     Console.WriteLine("Input integer power greater then 0");
//     power = Convert.ToInt32(Console.ReadLine());
//     //Сheck
//     if (power < 1)
//         {Console.WriteLine("ERROR! Input number must be >1 Try again");}
//     else 
//         {ERR=0;}
// }

// //Rezult
// Console.WriteLine($"Number {num}, power {power} is {FindPower(num,power)}");

//******************************************************************************************
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// //Method
// int FindSumDigit(int x)
// {
//     int sum=0;
//     while (x>=1)
//     {
//         sum+=x%10;
//         x/=10;
//     }
//     return sum;
// }

// //Initial data
// Console.WriteLine("Input ineger number");
// int num = Convert.ToInt32(Console.ReadLine());

// //Rezult
// Console.WriteLine($"Sum of digits number {num} is {FindSumDigit(num)}");

//*******************************************************************************************
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// int[] CreateRandomArray(int minValue, int maxValue)
// {
//     int[] array = new int[8];

//     for (int i=0;i<8;i++)
//     {
//         array[i]=new Random().Next(minValue,maxValue+1); //+1  так как метод с круглой скобки слева
//     }
//    return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i=0;i<array.Length;i++)
//     {
//         Console.Write(array[i]+" ");
//     }
//     Console.WriteLine();
// }

// // //Input
// Console.WriteLine("input min value");
// int min= Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("input max value");
// int max= Convert.ToInt32(Console.ReadLine());

// //Rezult
// int[] MyArray=CreateRandomArray(min,max);
// ShowArray(MyArray);
