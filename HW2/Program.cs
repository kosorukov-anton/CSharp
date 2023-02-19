//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

// //Method
// int FindSecondDigit(int x)
// {
//     return ((x%100)-x%10)/10;
// }

// //Initial data
// int ERR=1;
// int num=0;
// while (ERR==1)
// {
//     Console.WriteLine("Input integer 99<number<1000 ");
//     num = Convert.ToInt32(Console.ReadLine());
//     //Сheck
//     if (num<100 | num>999)
//         {Console.WriteLine("ERROR! Input must be: 99<number<1000 Try again");}
//     else 
//         {ERR=0;}
// }

// //Rezult output
// Console.WriteLine($"Second digit of {num} is {FindSecondDigit(num)}");

//*********************************************************************************************************
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// //Method
// void FindSecondDigit(double x)
// {
//     x=Math.Abs(x);
//     if (x>99)
//     {
//        int numDigit=2;
//        while (x/Math.Pow(10,numDigit)>1)
//        {
//             numDigit++;
//        }
//        double rezult= (x%(Math.Pow(10,numDigit-2))-x%(Math.Pow(10,numDigit-3)))/(Math.Pow(10,numDigit-3));
//        Console.WriteLine($"Third digit of {x} is {rezult}");
//     }
//     else
//     { Console.WriteLine($"Third digit dosen't exist");}
// }

// //Initial data
// Console.WriteLine("Input integer number");
// int num = Convert.ToInt32(Console.ReadLine());

// //Rezult output
// FindSecondDigit(num);

//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

// //Method
// void FindHoliday(int x)
// {
//     if(x%7==0)
//     {Console.WriteLine($"{x} --> yes");}
//     else
//     {
//         if (x%7==6)
//         {Console.WriteLine($"{x} --> yes");}
//         else
//         {Console.WriteLine($"{x} --> no");}
//     }    
// }

// //Initial data
// int num=0;
// int ERR=1;
// while (ERR==1)
// {
//     Console.WriteLine("Input integer number>0 ");
//     num = Convert.ToInt32(Console.ReadLine());
//     //Сheck
//     if (num<0)
//         {Console.WriteLine("ERROR! Input must be less then zero! Try again");}
//     else 
//         {ERR=0;}
// }

// //Rezult output
// FindHoliday(num);