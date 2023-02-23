Console.Clear();

// //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// //Method
// void FindPolydrom(int x)
// {
//     if (x%10 == x/10000)
//     {
//         if ( ((x/1000)%10) == ((x/10)%10))
//         {Console.WriteLine($"{x} --> yes!");}
//         else {Console.WriteLine($"{x} --> no!");}
//     }
//     else {Console.WriteLine($"{x} --> no!");}
// }

// //Initial data
// int ERR=1;
// int num=0;
// while (ERR==1)
// {
//     Console.WriteLine("Input integer 9 999<number<100 000 ");
//     num = Convert.ToInt32(Console.ReadLine());
//     //Сheck
//     if (num<10000| num>99999)
//         {Console.WriteLine("ERROR! Input number must be: 9 999<number<100 000 Try again");}
//     else 
//         {ERR=0;}
// }

// //Rezult
// FindPolydrom(num);

//*************************************************************************************************************
//Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.

//Method distance calc
// double FindDistance(double[] A, double[] B)
// {
//     double distance=0;
//     for (int i=0;i<=2;i++)
//     {
//         distance=distance+Math.Pow(A[i]-B[i],2);
//     }
//     distance=Math.Sqrt(distance);
//     return distance;
// }

// //Method coordinates from string
// double[] CoordinatesFromString(string Text)
// {
//     string[]  CoordinatesText = Text.Split(','); //координаты в текстовом формате
//     double[] Coordinates=new double[3]; //координаты
//     for (int i=0;i<=2;i++)
//     {
//         Coordinates[i]=Convert.ToDouble(CoordinatesText[i]);
//     }
//     return Coordinates;
// }

// //Initial data
// Console.WriteLine("Input three coordinates of first point, use symbol ',' between coordinates and point '.' between whole and fractional parts");
// string TextA=Console.ReadLine();
// double[] A = CoordinatesFromString(TextA);

// Console.WriteLine("Input three coordinates of second point, use symbol ',' between coordinates and point '.' between whole and fractional parts");
// string TextB=Console.ReadLine();
// double[] B = CoordinatesFromString(TextB);

////Rezult
// Console.WriteLine(FindDistance(A,B));


//*********************************************************************************************
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//Method
// int[] FindCubTable(int X)
// {
//     int[] CubTable=new int[X];
//     for(int i=1;i<=X;i++)
//     {
//         CubTable[i-1]=i*i*i;
//     }
//     return CubTable;
// }

// //Method
// void ShowArray(int[] array)
// {
//     for (int i=0;i<array.Length;i++)
//     {
//         Console.Write(array[i]+" ");
//     }
//     Console.WriteLine();
// }

// //Initial data
// Console.WriteLine("Input integer number");
// int num=Convert.ToInt32(Console.ReadLine());

// //Rezult
// ShowArray(FindCubTable(num));