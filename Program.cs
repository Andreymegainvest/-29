// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
// выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]
// int [] arrey = new int [8];
// int index = 0;
// int length = arrey.Length;
// while (index < length)
// {
//     arrey[index] = new Random().Next(20);
//     Console.Write(arrey[index] + " ");
//     index ++;
// }

//Задачи с семинара

// int [] array = new int[12];
// int resPositive = 0;
// int resNegative = 0;
// int index = 0;
// int length = array.Length;
// while (index < length)
// {
//     array[index] = new Random().Next(-9, 10);
//     Console.Write(array[index] + "\t");
//     if (array[index] > 0) resPositive +=array[index];
//     else resNegative += array[index];
//     index++;
// }
// Console.WriteLine();
// Console.WriteLine($"Сумма положительных чисел: {resPositive}, отрицательных: {resNegative}");


// Задача 32: Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] array = new int[8];
// int index = 0;
// int length = array.Length;
// while (index < length)
// {
//     array[index] = new Random().Next(-9, 10);
//     // array[index] = array[index] * (-1);
//     Console.Write(array[index] + "\t");
//     index++;
// }
// index = 0;
// Console.WriteLine();
// while (index < length)
// {
//     // array[index] = new Random().Next(-9, 10);
//     array[index] = array[index] * (-1);
//     Console.Write(array[index] + "\t");
//     index++;
// }
