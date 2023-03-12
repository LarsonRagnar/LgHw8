
// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] resultMatrix= GetMatrix(5,5,10,100);

// PrintMatrix(resultMatrix);
// Console.WriteLine("Результирующая матрица");
// SortRows(resultMatrix);
// PrintMatrix(resultMatrix);

/// <summary>
/// Этот метод заполняет двумерный массив числами от Min до max
/// </summary>
/// <param name="rows">Количество строк</param>
/// <param name="cols">количество столбцов</param>
/// <param name="min">Мин значение</param>
/// <param name="max">Макс значение</param>
/// <returns>Заполненый двумерный массив целых чисел</returns> 
// int[,] GetMatrix(int rows, int cols, int min, int max)
// {
//     int[,] matrix = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;

// }

/// <summary>
/// Метод печатает матрицу, которую передали
/// </summary>
/// <param name="InputMatrix">Двумерный массив или таблица</param>
// void PrintMatrix(int[,] InputMatrix)
// {
//     for (int i = 0; i < InputMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < InputMatrix.GetLength(1); j++)
//         {
//             Console.Write(InputMatrix[i,j]+ "\t");
//         }
//         Console.WriteLine();
//     }
// }

/// <summary>
///  сортировка пузырьком.Внутри цикла сравниваем элементы попарно, меняем местами, если они стоят в неправильном порядке
/// </summary>
/// <param name="matr">матрица двумерныйМассив</param>
// void SortRows(int[,] matr)
// {   
//     for (int i = 0; i < matr.GetLength(0); i++) 
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             for (int k = 0; k < matr.GetLength(1)-1; k++)
//             {
                
            
//                 if (matr[i,k]<matr[i,k+1])
//                 {
//                 int temp=matr[i,k];
//                 matr[i, k] = matr[i, k + 1];
//                 matr[i, k + 1] = temp;

//                 }
//             }    
//         }
//     }

// }



// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество строк: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// if (rows==cols)
// {
//     Console.WriteLine("матрица НЕ прямоугольная");
//     return;
    
// }
// int minSumRows = 0;
// int minSum = int.MaxValue;
// int[,] resultMatrix= GetMatrix(rows,cols,10,100);

// PrintMatrix(resultMatrix);
// Console.WriteLine("Результирующая матрица");
// SumRows(resultMatrix);
// PrintMatrix(resultMatrix);

/// <summary>
/// Этот метод заполняет двумерный массив числами от Min до max
/// </summary>
/// <param name="rows">Количество строк</param>
/// <param name="cols">количество столбцов</param>
/// <param name="min">Мин значение</param>
/// <param name="max">Макс значение</param>
/// <returns>Заполненый двумерный массив целых чисел</returns> 
// int[,] GetMatrix(int rows, int cols, int min, int max)
// {
//     int[,] matrix = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;

// }

/// <summary>
/// Метод печатает матрицу, которую передали
/// </summary>
/// <param name="InputMatrix">Двумерный массив или таблица</param>
// void PrintMatrix(int[,] InputMatrix)
// {
//     for (int i = 0; i < InputMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < InputMatrix.GetLength(1); j++)
//         {
//             Console.Write(InputMatrix[i,j]+ "\t");
//         }
//         Console.WriteLine();
//     }
// }

/// <summary>
/// Метод проходит по каждой строчке массива и считает сумму элементов в каждой и сравнивает их с минимальной
/// </summary>
/// <param name="matr">матрица двумерныйМассив</param>
// void SumRows(int[,] matr)
// { 
//     for (int i = 0; i < matr.GetLength(0); i++) // элемент таблицы из 0 строчку i столбца
//     {   
//         int sum = 0;
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {   
//             sum += matr[i, j];
//             if (sum < minSum)
//             {
//                 minSum = sum;
//                 minSumRows = i;
//             }
//         }
         

//     }
//     Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRows}");


// }




// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] oneMatrix= GetMatrix(2,2,10,100);
// Console.WriteLine("Первая матрица");
// PrintMatrix(oneMatrix);
// Console.WriteLine("Вторая матрица");
// int[,] twoMatrix= GetMatrix(2,2,10,100);
// PrintMatrix(twoMatrix);

// PrintMatrix(resultMatrix);

/// <summary>
/// Этот метод заполняет двумерный массив числами от Min до max
/// </summary>
/// <param name="rows">Количество строк</param>
/// <param name="cols">количество столбцов</param>
/// <param name="min">Мин значение</param>
/// <param name="max">Макс значение</param>
/// <returns>Заполненый двумерный массив целых чисел</returns> 
// int[,] GetMatrix(int rows, int cols, int min, int max)
// {
//     int[,] matrix = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;

// }

/// <summary>
/// Метод печатает матрицу, которую передали
/// </summary>
/// <param name="InputMatrix">Двумерный массив или таблица</param>
// void PrintMatrix(int[,] InputMatrix)
// {
//     for (int i = 0; i < InputMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < InputMatrix.GetLength(1); j++)
//         {
//             Console.Write(InputMatrix[i,j]+ "\t");
//         }
//         Console.WriteLine();
//     }
// }



// int  ComposMatr(int[,] matr)
// {   
//     int composMatrix=0;
//     int composMatr=1;
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {   
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             composMatr*=matr[i, j];
//             composMatrix=composMatr;
//         }
//     }
//     return composMatrix;

// }
// ComposMatr(oneMatrix);
// ComposMatr(twoMatrix);
// int composOneMatrix = ComposMatr(oneMatrix);
// Console.WriteLine($"Произведение первой матрицы {composOneMatrix}");

// int composTwoMatrix = ComposMatr(twoMatrix);
// Console.WriteLine($"Произведение второй матрицы {composTwoMatrix}");


// Console.WriteLine($"Произведение первой и второй матриц: {composOneMatrix * composTwoMatrix}");








// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)


// int[,,] myArray = new int[4, 4, 4];
// int count = 4;
// int num = 1;

// for (int i = 0; i < count; i++) {
//   for (int j = 0; j < count; j++) {
//     for (int k = 0; k < count; k++) {
//       myArray[i,j,k] = num;
//       num++;
//       }
//     }
//   }
// for (int i = 0; i < count; i++) {
//   for (int j = 0; j < count; j++) {
//     for (int k = 0; k < count; k++) {
//       Console.WriteLine($"myArray[{i},{j},{k}] = {myArray[i,j,k]}");
//     }
//   }
// }