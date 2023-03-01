Console.Clear();

//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// //Method FindChet
// int FindChet(int[] array)
// {
//     int count=0;
//     for(int i=0;i<array.Length;i++)
//     {
//         if(array[i]%2==0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// //Method Create array
// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for (int i=0;i<size;i++)
//     {
//         array[i]=new Random().Next(minValue,maxValue+1); //+1  так как метод с круглой скобки слева
//     }
//    return array;
// }

// //Method Show array
// void ShowArray(int[] array)
// {
//     for (int i=0;i<array.Length;i++)
//     {
//         Console.Write(array[i]+" ");
//     }
//     Console.WriteLine();
// }

// //Input
// int ERR=1;
// int size=0;
// while (ERR==1)
// {
//     Console.WriteLine("input array size >=1");
//     size = Convert.ToInt32(Console.ReadLine());
//     //Сheck
//     if (size < 1)
//         {Console.WriteLine("ERROR! Input number must be >1 Try again");}
//     else 
//         {ERR=0;}
// }

// ERR=1;
// int min=0;
// while (ERR==1)
// {
//     Console.WriteLine("input min value of array element: 100-998");
//     min = Convert.ToInt32(Console.ReadLine());
//     //Сheck
//     if (min<100|min>998)
//         {Console.WriteLine("ERROR! Input number must be >99 Try again");}
//     else 
//         {ERR=0;}
// }

// ERR=1;
// int max=0;
// while (ERR==1)
// {
//     Console.WriteLine("input max value of array element 101-999, and bigger then min value");
//     max = Convert.ToInt32(Console.ReadLine());
//     //Сheck
//     if (max<=min|max>999)
//         {Console.WriteLine("ERROR! Try again");}
//     else 
//         {ERR=0;}
// }


// //Rezult
// int[] MyArray=CreateRandomArray(size,min,max);
// ShowArray(MyArray);
// Console.WriteLine($"array has {FindChet(MyArray)} even number");


// //***************************************************************************
// //Задайте одномерный массив, заполненный случайными числами. 
// //Найдите сумму элементов, стоящих на нечётных позициях.
// //Method FindSum
// double FindSumNechet(double[] array)
// {
//     double sum=0;
//     for(int i=1;i<array.Length;i+=2)
//     {
//         sum+=array[i];
//     }
//     return sum;
// }
// //Method Create array
// double[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     double[] array = new double[size];

//     for (int i=0;i<size;i++)
//     {
//         array[i]=Math.Round(new Random().NextDouble()*(maxValue-minValue)+minValue,2);
//         Console.Write(array[i]+" ");
//     }
//    Console.WriteLine();
//    return array;
// }

// // Input
// Console.WriteLine("Input array size>2");
// int size= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimum value of array elements");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximum value of array elements");
// int min = Convert.ToInt32(Console.ReadLine());

// //Calculation
// Console.WriteLine($" Sum is {FindSumNechet(CreateRandomArray(size, max, min))}");

//*********************************************************************************************************
//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//Method FindDifMaxMin
// double FindDifMaxMin(double[] array)
// {
//     double dif=0;
//     double max=array[0], min=max;
//     for(int i=1;i<array.Length;i++)
//     {
//         if (array[i]>max) {max=array[i];}

//         if (array[i]<min) {min=array[i];}

//     }
//     dif=max-min;
//     return dif;
// }
// //Method Create array
// double[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     double[] array = new double[size];

//     for (int i=0;i<size;i++)
//     {
//         array[i]=Math.Round(new Random().NextDouble()*(maxValue-minValue)+minValue,2);
//         Console.Write(array[i]+" ");
//     }
//    Console.WriteLine();
//    return array;
// }

// // Input
// Console.WriteLine("Input array size>2");
// int size= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimum value of array elements");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximum value of array elements");
// int min = Convert.ToInt32(Console.ReadLine());

// //Calculation
// Console.WriteLine($" difference between max and min is {FindDifMaxMin(CreateRandomArray(size, max, min))}");