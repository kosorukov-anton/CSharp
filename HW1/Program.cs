Console.Clear();

//Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//Initial data
// double num1 = 0, num2 = 0;
// while (num1==num2)
// {
//     Console.WriteLine("Input first number");
//     num1 = Convert.ToDouble(Console.ReadLine());
//     Console.WriteLine("Input second number");
//     num2 = Convert.ToDouble(Console.ReadLine());
    
//     //Check
//     if (num1==num2)
//     {Console.WriteLine("ERROR! The numbers are equal. Try again");}
// }

// //Comparison and rezult output
// if (num1>num2)
// {Console.WriteLine($"Number {num1} is bigger then {num2}");}
// else
// {Console.WriteLine($"Number {num2} is bigger then {num1}");}

//*************************************************************************************
//Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
//Initial data
// double[] num = new double[3];
// int ERR=1;
// while (ERR==1)
// {
//     for (int i = 0; i < 3; i++)
//     {
//         Console.WriteLine("Input number");
//         num[i] = Convert.ToDouble(Console.ReadLine());
//     }

//     //Сheck
//     if (num[0]==num[1] && num[1]==num[2])
//         {Console.WriteLine("ERROR! The numbers are equal. Try again");}
//     else 
//         {ERR=0;}
// }

// //Search max number
// double max=num[0];
// for (int i = 1; i < 3; i++)
// {
//     if (num[i]>max)
//     {max=num[i];}
// }

// // Rezult output
// Console.WriteLine("You give me 3 numbers:");
// Console.WriteLine(num[0]+"  "+num[1]+" and "+num[2]);
// Console.WriteLine($"I help you, max value is {max}");

//**************************************************************************************************
//Задача 3.  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
// Console.WriteLine("Input integer number");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num%2==0)
// {Console.WriteLine($"{num} is even number");}
// else
// {Console.WriteLine($"{num} is't even number");}

//**************************************************************************************************
//Задача 4.  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
// int ERR=1;
// int num=0;
// while (ERR==1)
// {
//     Console.WriteLine("Input integer number bigger then 1 (>=2)");
//     num = Convert.ToInt32(Console.ReadLine());

//     //Сheck
//     if (num<2)
//         {Console.WriteLine("ERROR! Input number less then <2. Try again");}
//     else 
//         {ERR=0;}
// }

// Console.WriteLine($"Even numbers from 2 to {num}:");
// int i=2;
// while(i<=num)
// {
//     Console.Write(i+"  ");
//     i=i+2;
// }