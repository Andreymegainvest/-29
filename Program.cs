// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
// выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]
int [] arrey = new int [8];
int index = 0;
int length = arrey.Length;
while (index < length)
{
    arrey[index] = new Random().Next(20);
    Console.Write(arrey[index] + " ");
    index ++;
}


