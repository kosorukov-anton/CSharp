Console.Clear();

//Задача 1. Запрос числа - вывод квадрата
// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Sq {num} is {num*num}");

//Задача 2
// Console.WriteLine("Input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int sqare=num2*num2;
// if (sqare == num1)
// {    Console.WriteLine($"Number {num1} is sqare of {num2}");}
// else
// {    Console.WriteLine($"Number {num1} is NOT sqare of {num2}");}

// //Задача 3 Принимаем число и выводим диапазон
// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// int current=-num;
// while(current<=num)
// {   Console.Write(current + " ");
//     current++;}

//Задача 4 Остаток от деления на 10
Console.WriteLine("Input three digit number");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"Last digit is {num%10}");