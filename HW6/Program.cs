Console.Clear();

// //Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// //Method to count how mach numbers is more than zero
// int FindMoreZero(double[] array)
// {
//     int count=0;
//     for (int i=0;i<array.Length;i++)
//     {
//         if (array[i]>0) {count+=1;}
//     }
//     return count;
// }

// //Method array from string
// double[] ArrayFromString(string Text)
// {
//     string[]  ArrayText = Text.Split(','); //числа в текстовом формате
//     double[] NumArray=new double[ArrayText.Length];
//     for (int i=0;i<ArrayText.Length;i++)
//     {
//         NumArray[i]=Convert.ToDouble(ArrayText[i]); //числовой массив из текстового
//         Console.Write(NumArray[i]+" ");
//     }
//     Console.WriteLine();
//     return NumArray;
// }

// //Initial data
// Console.WriteLine("Input numbers, use symbol ',' between numbers and point '.' between whole and fractional parts");
// string TextNumbers=Console.ReadLine();
// double[] ArrayNum = ArrayFromString(TextNumbers);

// //Rezult
// Console.WriteLine($"Numbers more the zero is {FindMoreZero(ArrayNum)}");

// //**************************************************************************************************
// //Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями

// //Metohod
// void FindCrossPoint(double k1, double b1, double k2, double b2)
// {
//     if (k1==k2)
//     {Console.WriteLine($"lines is parallel");}
//     else
//     {
//         double xcross=(b2-b1)/(k1-k2);
//         double ycross=k1*xcross+b1;
//         Console.WriteLine($"Cross poin coordinates is ({xcross} , {ycross})");
//     }
// }

// //Input
// Console.WriteLine("Input coefficient k1");
// double k1=Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coefficient b1");
// double b1=Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coefficient k2");
// double k2=Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coefficient b2");
// double b2=Convert.ToDouble(Console.ReadLine());

// //Rezult
// FindCrossPoint(k1,b1,k2,b2);