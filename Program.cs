﻿
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Console.Write("Введите m: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите n: ");
// int n = int.Parse(Console.ReadLine());

// Console.WriteLine($"m = {m}, n = {n}.");

// double[,] array = new double[m, n];

// CreateArrayDouble(array);

// WriteArray(array);

// Console.WriteLine();

// void CreateArrayDouble(double[,] array)
// {
//   for (int i = 0; i < m; i++)
//   {
//     for (int j = 0; j < n; j++)
//     {
//       array[i, j] = new Random().NextDouble() * 20 - 10;
//     }
//   }
// }

// void WriteArray (double[,] array){
// for (int i = 0; i < m; i++)
//   {
//       for (int j = 0; j < n; j++)
//       {
//         double alignNumber = Math.Round(array[i, j], 1);
//         Console.Write(alignNumber + " ");
//       }
//       Console.WriteLine();
//   }
// }




// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


// Console.Write("Введите a: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите b: ");
// int b = int.Parse(Console.ReadLine());

// Console.WriteLine($"m = {a}, n = {b}.");

// double[,] array = new double[a, b];

// string? positionElement = Console.ReadLine();
// positionElement = RemovingSpaces(positionElement);
// int[] position = ParserString(positionElement);

// if(position[0] <= a 
// && position[1] <= b 
// && position[0] >= 0 
// && position[1] >= 0) 
// {
//   double result = array[position[0]-1, position[1]-1];
//   Console.Write($"Значение элемента: {result}");
// }
// else Console.Write($"такого элемента в массиве нет.");

// int[] ParserString(string input)
// {
//   int countNumbers = 1;
//   for (int i = 0; i < input.Length; i++)
//   {
//       if (input[i] == ',')
//           countNumbers++;
//   }

//   int[] numbers = new int[countNumbers];

//   int numberIndex = 0;
//   for(int i = 0; i < input.Length; i++)
//   {
//     string subString = String.Empty;

//     while (input[i] != ',')
//     {
//       subString += input[i].ToString();
//       if (i >= input.Length - 1)
//         break;
//       i++;
//     }
//     numbers[numberIndex] = int.Parse(subString);
//     numberIndex++;
//   }

//   return numbers;
// }

// string RemovingSpaces (string input)
// {
//   string output = String.Empty;
//   for (int i = 0; i < input.Length; i++)
//   {
//     if (input[i] != ' ') 
//     {
//       output += input[i];
//     }
//   }
//   return output;
// }