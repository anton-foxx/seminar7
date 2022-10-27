// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// int m = 3;
// int n = 4;
// double[,] matrix = new double[m, n];
// Random rnd = new Random();
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = Math.Round(rnd.Next(-1000, 1001) / 1.2, 2);
//     }
// }
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i,j]} ");
//     }
//     Console.WriteLine();
// }




// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int[,] rndArray = new int[3, 4];
// Random rnd1 = new Random();
// for (int i = 0; i < rndArray.GetLength(0); i++)
// {
//     for (int j = 0; j < rndArray.GetLength(1); j++)
//     {
//         rndArray[i,j] = rnd1.Next(1, 10);
//         Console.Write($"{rndArray[i, j]} ");
//     }
//     Console.WriteLine();
// }
//     Console.WriteLine();
//     Console.WriteLine("Введите число от 1 до 10");
//     int num = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i < rndArray.GetLength(0); i++)
// {
//     for (int j = 0; j < rndArray.GetLength(1); j++)
//     {
//         if (rndArray[i ,j] == num)
//         {
//             Console.Write($"{num} Да");
//         }
//     }
//     Console.WriteLine();
// }


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// double[,] MatrixInputDouble(int row, int col)
// {
//     double[,] matrix = new double[row, col];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < col; j++)
//         {
//             matrix[i, j] = new Random().Next(-9, 9);
//         }
//     }
//     return matrix;
// }
// void MatrixOutput(double[,] matrix)
// {
//     Console.WriteLine();
//     Console.WriteLine($"Матрица сгенерирована {matrix.GetLength(0)} * {matrix.GetLength(1)}");
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (matrix[i, j] >= 0) Console.Write("" + matrix[i, j] + " ");
//             else Console.Write(matrix[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// void MatrixAverageCol(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         double averageCol, sumCol = 0;
//         for (int j = 0; j < matrix.GetLength(0); j++)
//         {
//             sumCol += matrix[j, i];
//         }
//         averageCol = Math.Round(sumCol / matrix.GetLength(0), 1);
//         Console.WriteLine($"Среднее арифметическое по столбцу {i + i} равно {averageCol} (сумма элементов - {sumCol})");
//     }
// }
// int rowMatrix = new Random().Next(3, 7);
// int colMatrix = new Random().Next(3, 7);

// double[,] matrix = MatrixInputDouble(rowMatrix, colMatrix);
// MatrixOutput(matrix);
// MatrixAverageCol(matrix);