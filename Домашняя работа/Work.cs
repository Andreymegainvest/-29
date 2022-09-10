// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 


// int[] array = new int[4];
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new  Random().Next(100,1000);
//     Console.Write(array[i] + " ");
//     if (array[i] % 2 == 0) count++;
// }
// Console.WriteLine();
// Console.WriteLine(count);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] array = new int[4];
// int sum = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new  Random().Next(10);
//     Console.Write(array[i] + " ");
//     if (i % 2 != 0)
//     {
//         sum = sum + array[i];
//     }
//     }
// Console.WriteLine();
// Console.WriteLine($"Сумма элементов стоящих на нечётных позициях: {sum} ");


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76. double

// double[] array = new  double[4];
// double maxNumber = array[0];
// double minNumber = array[0];
// double result = 0;
// for (int i = 0; i < array.Length; i++)
// {
// array[i] = new  Random().Next(10);
// Console.Write(array[i] + " ");
// if (maxNumber < array[i])
// {
//     maxNumber = array[i];
// }
// if (minNumber > array[i])
// {
//     minNumber = array[i];
// }
// }
// result = maxNumber - minNumber;

// Console.WriteLine();
// Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {result} ");


double[] array = new double[4];
  for (int i = 0; i < array.Length; i++ )
  {
    array[i] = new Random().Next(20);
    Console.Write(array[i] + " ");
  }

double maxNumber = array[0];
double minNumber = array[0];

  for (int i = 1; i < array.Length; i++)
  {
    if (maxNumber < array[i])
    {
      maxNumber = array[i];
    }
        if (minNumber > array[i])
    {
      minNumber = array[i];
    }
  }

  double result = maxNumber - minNumber;

  Console.WriteLine($"\nРазница между максимальным и минимальным элементами: {result}");
