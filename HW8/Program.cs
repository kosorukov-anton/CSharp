//Common Methods, do not comment it)
Console.Clear();

int[,] CreateRandom2DArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] array = new int[rows,colums];
    for (int i=0;i<rows;i++)
    {
        for (int j=0;j<colums;j++)
        {array[i,j]=new Random().Next(minValue,maxValue+1);}
    }
   return array;
}
//show array 
void Show2DArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        {Console.Write(array[i,j]+" ");}
        Console.WriteLine();
    }
    Console.WriteLine();
}

// //********************************************************************************************************************************
// // Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// //Method
// int[,] SortRow2Darray(int[,] array)
// {
//     for (int i=0;i<array.GetLength(0);i++) //rows change
//     {
//         //sorting row
//         for (int j=array.GetLength(1)-1;j>0;j--)
//         {
//             for (int k = 0; k < j; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k];
//                     array[i, k] = array[i, k + 1];
//                     array[i, k + 1] = temp;
//                 }
//             }
//         }
//     }
//     return array;
// }

// //Input
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
// Show2DArray(SortRow2Darray(myArray));

// //************************************************************************************************
// //Напишите программу, которая будет находить строку с наименьшей суммой элементов. 
// //Method
// int FindMinSumRow(int [,] array)
// {
//     int numMinSumRow=0;
//     int minSum=0;
//     for (int i=0;i<array.GetLength(0);i++)
//     {
//         int sum=0;

//         for (int j=0;j<array.GetLength(1);j++)
//         {
//             sum+=array[i,j];
//         }
//         Console.WriteLine(sum);
//         if (sum<minSum) {minSum=sum;numMinSumRow=i;}
//     }
//     Console.WriteLine();
//     return numMinSumRow+1;
// }

// //Input
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
// Console.WriteLine($"Rows with min sum of elements is {FindMinSumRow(myArray)}");


// //**************************************************************************************************
// //Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. 
// //Method multiplication of A and B matrix
// int[,] MultiMatrix(int[,] A, int[,] B)
// {
//     int[,] C=new int[A.GetLength(0), B.GetLength(1)];

//     //Multiplication of A and B posible
//     if (A.GetLength(1)!= B.GetLength(0)) {return C;}
      
//     for (int i=0;i<A.GetLength(0);i++)
//     {
//         for (int j=0;j<B.GetLength(1);j++)
//         {
//             C[i,j]=0;
//             for (int k=0;k<A.GetLength(1);k++)
//             {
//                 C[i,j]+=A[i,k]*B[k,j];
//             }
//         }
//     }
//     return C;
// }

// //Input
// Console.WriteLine("Input number of A rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of A colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of A array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of A array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myA=CreateRandom2DArray(rows, colums, minValue, maxValue);


// Console.WriteLine("Input number of B rows: ");
// rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of B colums: ");
// colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of B array element");
// minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of B array element");
// maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myB=CreateRandom2DArray(rows, colums, minValue, maxValue);

// Console.WriteLine("A=");
// Show2DArray(myA);
// Console.WriteLine("B=");
// Show2DArray(myB);
// Console.WriteLine("C=AxB");
// //Calculations
// Show2DArray(MultiMatrix(myA, myB));

// //**************************************************************************************************
// // Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// //Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. 
// int[,,] CreateRandom3DArray(int rows, int colums, int section,int minValue, int maxValue)
// {
//     int[,,] array = new int[rows,colums,section];
//     for (int i=0;i<rows;i++)
//     {
//         for (int j=0;j<colums;j++)
//         {
//             for (int k=0;k<colums;k++)
//             {array[i,j,k]=new Random().Next(minValue,maxValue+1);}
//         }
//     }
//    return array;
// }
// //show array 
// void Show3DArray(int[,,] array)
// {
//     for (int k=0;k<array.GetLength(2);k++)
//     {
//         for (int i=0;i<array.GetLength(0);i++ )
//         {
//             for (int j=0;j<array.GetLength(1);j++ )
//             {Console.Write($" {array[i,j,k]} ({i},{j},{k})");}
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// //Input
// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of section: ");
// int section = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,,] myArray=CreateRandom3DArray(rows,colums,section,minValue,maxValue);
// Show3DArray(myArray);

//**************************************************************************************************
//Напишите программу, которая заполнит спирально массив 4 на 4.
//Method FillArray
int[,] Fill2DArray(int rows, int colums)
{
    int[,] array = new int[rows,colums];
    int i=0, j=0;
    int di=0; //rows direction from start point [0,0]
    int dj=1; //column direction from start point [0,0]
    int changeNeed=0; //if=1 then we have to change direction next step, 0 - no need
    int temp=0; //temp value to provide change direction
    for (int k=0;k<rows*colums;k++)
    {
        array[i,j]=k+1;
        Show2DArray(array);
        //Need to change direction?
        if ( i+di>rows-1 || i+di<0 || j+dj>colums-1 || j+dj<0) {changeNeed=1;} //out of range condition
        else
        {
            if(array[i+di,j+dj]!=0) //in range filled element forvard
            {changeNeed=1;}
        }
        //change direction
        if(changeNeed==1)
        {
            temp=di;
            di=dj;
            dj=-temp;
            changeNeed=0;
        }
        //next position
        i=i+di; 
        j=j+dj;
    }
    return array;
}

//Input
Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());

//Calculations
int[,] myArray = Fill2DArray(rows, colums);