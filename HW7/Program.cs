Console.Clear();

// //Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// double[,] CreateRandom2DArray(int rows, int colums, int minValue, int maxValue)
// {
//     double[,] array = new double[rows,colums];

//     for (int i=0;i<rows;i++)
//     {
//         for (int j=0;j<colums;j++)
//         {
//         array[i,j]=Math.Round(new Random().NextDouble()*(maxValue-minValue)+minValue,2);
//         }
//     }
//    return array;
// }

// void Show2DArray(double[,] array)
// {
//     for (int i=0;i<array.GetLength(0);i++)
//     {
//         for (int j=0;j<array.GetLength(1);j++)
//         {Console.Write(array[i,j]+" ");}
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// double[,] array = CreateRandom2DArray(colums, rows, minValue, maxValue);
// Show2DArray(array);

//********************************************************************************
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// //array creation 
// int[,] CreateRandom2DArray(int rows, int colums, int minValue, int maxValue)
// {
//     int[,] array = new int[rows,colums];
//     for (int i=0;i<rows;i++)
//     {
//         for (int j=0;j<colums;j++)
//         {array[i,j]=new Random().Next(minValue,maxValue+1);}
//     }
//    return array;
// }

// //show array 
// void Show2DArray(int[,] array)
// {
//     for (int i=0;i<array.GetLength(0);i++)
//     {
//         for (int j=0;j<array.GetLength(1);j++)
//         {Console.Write(array[i,j]+" ");}
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// //Method array from string
// int[] ArrayFromString(string Text)
// {
//     string[]  arrayText = Text.Split(','); //числа в текстовом формате
//     int[] numArray=new int[arrayText.Length];
//     for (int i=0;i<arrayText.Length;i++)
//     {
//         numArray[i]=Convert.ToInt16(arrayText[i])-1; //числовой массив из текстового
//     }
//     return numArray;
// }
// //Method find element
// void FindElement(int[,] array,int [] numArray)
// {
//     int Find=0;
//     for(int i=0;i<numArray.Length;i++)
//     {
//     if (numArray[i]>array.GetLength(i))
//         {Console.WriteLine("Element not found");
//         Find=1;
//         }
//     }
//     if (Find==0)
//     {Console.WriteLine($"Element is {array.GetValue(numArray)}");}
// }

// //Input
// //array information
// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// //input index
// Console.WriteLine("Input index of element to be searched. Use ',' between indexes");
// string TextNumbers=Console.ReadLine();

// //Calculations
// int[,] myArray = CreateRandom2DArray(rows, colums, minValue, maxValue);
// Show2DArray(myArray);

// int[] numArray = ArrayFromString(TextNumbers);
// FindElement(myArray, numArray);


//*****************************************************************************************
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// //array creation 
// int[,] CreateRandom2DArray(int rows, int colums, int minValue, int maxValue)
// {
//     int[,] array = new int[rows,colums];
//     for (int i=0;i<rows;i++)
//     {
//         for (int j=0;j<colums;j++)
//         {array[i,j]=new Random().Next(minValue,maxValue+1);}
//     }
//    return array;
// }

// //show array 
// void Show2DArray(int[,] array)
// {
//     for (int i=0;i<array.GetLength(0);i++)
//     {
//         for (int j=0;j<array.GetLength(1);j++)
//         {Console.Write(array[i,j]+" ");}
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// //Method median
// void FindMedianColum(int[,] array)
// {
//     for (int j=0;j<array.GetLength(1);j++)
//     {
//         double sum=0;
//         for(int i=0;i<array.GetLength(0);i++)
//         {
//             sum+=array[i,j];
//         }
//         sum=sum/array.GetLength(0);
//         Console.Write(sum+"; ");
//     }
// }

// // //Input
// //array information
// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// //Calculations
// int[,] myArray = CreateRandom2DArray(rows, colums, minValue, maxValue);
// Show2DArray(myArray);
// FindMedianColum(myArray);