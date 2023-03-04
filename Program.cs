// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Задайте количество строк двумерного массива:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Задайте количество столбцов двумерного массива:");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] twoDimArray = new double[m, n];

// void FillArray(double[,] matr)
// { for (int i = 0; i < m; i++)
//  { for (int j = 0; j < n; j++)
//  matr[i,j] = Convert.ToDouble(new Random().Next(-100, 100)/10.0);
//  }
// }

// void PrintArray(double[,] matr)
// { for (int i = 0; i < m; i++)
//  { for (int j = 0; j < n; j++)
//   Console.Write($"{matr[i, j]} ");
//  Console.WriteLine();
// }
// }


// FillArray(twoDimArray);
// Console.WriteLine();
// PrintArray(twoDimArray);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int[,] myArray = new int [3,4];

// void FillArray(int[,] myArray)
// {
// for (int i = 0; i < myArray.GetLength(0); i++)
// {
//     for (int j = 0; j < myArray.GetLength(1); j++)
//     {
//         myArray[i,j] = new Random().Next(0,5);
//     } 
// }
// }

// void Findnumber(int [,] myArray)
// {  
// Console.WriteLine("введите номер строки");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите номер столбца");
// int m = Convert.ToInt32(Console.ReadLine());

//         if (n>myArray.GetLength(0)||m>myArray.GetLength(1))
//         {
//         System.Console.Write("Элемента с таким индексом нет");
//         }
//         else
//         {
//             System.Console.WriteLine($"Значение элемента {n} строики и {m} столбца равно {myArray[n-1, m-1]}");
//         }
// }

// void PrintArray(int[,] myArray)
// { 
//     for (int i = 0; i < myArray.GetLength(0); i++)
//   { 
//     for (int j = 0; j < myArray.GetLength(1); j++)
//     {
//        Console.Write($"{myArray[i, j]} ");
       
//     }   
//     System.Console.WriteLine();
//   }
// }
// FillArray(myArray);
// PrintArray(myArray);
// Findnumber(myArray);

// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
double[,] DimArray = new double[m, n];

void FillArray(double[,] matr)
{ for (int i = 0; i < m; i++)
 { for (int j = 0; j < n; j++)
 matr[i,j] = Convert.ToDouble(new Random().Next(-100, 100)/10.0);
 }
}

double AverageColumns(double[,] matr)
{
    double result = Convert.ToDouble(matr[1,m]/n);
    
    return result;
}

void PrintArray(double[,] matr)
{ for (int i = 0; i < m; i++)
 { for (int j = 0; j < n; j++)
  Console.Write($"{matr[i, j]} ");
 Console.WriteLine();
 }
 }

FillArray(DimArray);
Console.WriteLine();
AverageColumns(DimArray);
Console.WriteLine();
PrintArray(DimArray);