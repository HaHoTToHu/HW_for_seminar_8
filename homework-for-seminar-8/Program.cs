/*Задача 54.Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.*/

// Console.WriteLine("Введите диапазон чисел: ");
// int range = Convert.ToInt32(Console.ReadLine());

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void ShowArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

// void OrderedArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1) - 1; k++)
//       {
//         if (array[i, k] < array[i, k + 1])
//         {
//           int temp = array[i, k + 1];
//           array[i, k + 1] = array[i, k];
//           array[i, k] = temp;
//         }
//       }
//     }
//   }
// }
// Console.WriteLine("Введите m: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[m, n];
// CreateArray(array);
// ShowArray(array);

// Console.WriteLine($"Упорядоченный массив: ");

// OrderedArray(array);
// ShowArray(array);

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.*/

// Console.WriteLine("Введите диапазон чисел: ");
// int range = Convert.ToInt32(Console.ReadLine());

// void CreateArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(range);
//         }
//     }
// }

// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void NaimSumElem(int[,] array)
// {
//     int minSumLine = 0;
//     int sumLine = SumLineElements(array, 0);
//     for (int i = 1; i < array.GetLength(0); i++)
//     {
//         int tempSumLine = SumLineElements(array, i);
//         if (sumLine > tempSumLine)
//         {
//             sumLine = tempSumLine;
//             minSumLine = i;
//         }
//     }
//     Console.WriteLine($"{minSumLine + 1} - Строка с наименьшей суммой элементов. Сумма эл-тов в этой строке: {sumLine}");
// }

// int SumLineElements(int[,] array, int i)
// {
//     int sumLine = array[i, 0];
//     for (int j = 1; j < array.GetLength(1); j++)
//     {
//         sumLine += array[i, j];
//     }
//     return sumLine;
// }


// Console.WriteLine("Введите m: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[m, n];
// CreateArray(array);
// ShowArray(array);
// NaimSumElem(array);

/*Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.*/

// Console.WriteLine("Введите диапазон чисел: ");
// int range = Convert.ToInt32(Console.ReadLine());

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void ShowArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

// void UmnozhenieMatritz(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
// {
//   for (int i = 0; i < resultMatrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < firstMartrix.GetLength(1); k++)
//       {
//         sum += firstMartrix[i,k] * secomdMartrix[k,j];
//       }
//       resultMatrix[i,j] = sum;
//     }
//   }
// }

// Console.WriteLine("Введите число строк 1-й матрицы: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число столбцов 1-й матрицы и строк 2-й матрицы: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число столбцов 2-й матрицы: ");
// int p = Convert.ToInt32(Console.ReadLine());

// int[,] firstMartrix = new int[m, n];
// CreateArray(firstMartrix);
// Console.WriteLine($"First matrix: ");
// ShowArray(firstMartrix);

// int[,] secomdMartrix = new int[n, p];
// CreateArray(secomdMartrix);
// Console.WriteLine($"Second Matrix: ");
// ShowArray(secomdMartrix);

// int[,] resultMatrix = new int[m,p];

// UmnozhenieMatritz(firstMartrix, secomdMartrix, resultMatrix);
// Console.WriteLine($"Multiplexion of Matrix: ");
// ShowArray(resultMatrix);

/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2*/

// int[,,] CreateArray(int[] size, int min, int max)
// {
//     int[,,] result = new int[size[0], size[1], size[2]];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             int k = 0;
//             while (k < result.GetLength(2))
//             {
//                 int element = new Random().Next(min, max + 1);
//                 if (FindElement(result, element)) continue;
//                 result[i, j, k] = element;
//                 k++;
//             }
//         }
//     }
//     return result;
// }

//         bool FindElement(int[,,] array, int el)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 if (array[i, j, k] == el) return true;
//             }
//         }
//     }
//     return false;
// }
// void ShowArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
//             }
//             Console.WriteLine();

//             Console.ReadKey();
//         }
//     }
// }

// Console.WriteLine("Введите размеры массива через пробел: ");
// string[] numbers = Console.ReadLine().Split(" ");
// int[,,] array = CreateArray(new int[] { int.Parse(numbers[0]), int.Parse(numbers[1]), int.Parse(numbers[2]), }, 10, 99);
// ShowArray(array);

/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.*/

// int size = 4;
// int[,] MatrixForxFor = new int[size, size];

// int temp = 1;
// int i = 0;
// int j = 0;

// while (temp <= MatrixForxFor.GetLength(0) * MatrixForxFor.GetLength(1))
// {
//     MatrixForxFor[i, j] = temp;
//     temp++;
//     if (i <= j + 1 && i + j < MatrixForxFor.GetLength(1) - 1)
//         j++;
//     else if (i < j && i + j >= MatrixForxFor.GetLength(0) - 1)
//         i++;
//     else if (i >= j && i + j > MatrixForxFor.GetLength(1) - 1)
//         j--;
//     else
//         i--;
// }

// ShowArray(MatrixForxFor);

// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] / 10 <= 0)
//                 Console.Write($" {array[i, j]} ");

//             else Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }