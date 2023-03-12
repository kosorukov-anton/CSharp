Console.Clear();

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// void ShowNumbers(int n)
// {
//     if(n>=1)
//     {
//         Console.Write(n + " ");
//         ShowNumbers(n-1);
//     }
// }
// //Input
// Console.WriteLine("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// ShowNumbers(n);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
//в промежутке от M до N.
// int FindSumNumMN(int m, int n)
// {
//     if (m==n) {return m;}
//     else if (m>n) {return n+FindSumNumMN(m,n+1);}
//     else {return n+FindSumNumMN(m,n-1);}
// }
// Console.WriteLine("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("sum of numbers is "+ FindSumNumMN(m, n));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// int Akkerman(int m, int n)
// {
//     if(m==0){return n+1;}
//     else if(m>0 && n==0){return Akkerman(m-1,1);}
//     else {return Akkerman(m-1,Akkerman(m,n-1));}
// }
// Console.WriteLine("Input m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("rezult is "+ Akkerman(m, n));