/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

Console.WriteLine("Зададим двумерный массив случайных целых чисел.");

Console.Write("Количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine());

Console.WriteLine("Полученный массив: ");
int [,] array = FillArray(rows, columns, 1 , 10);
PrintArray(array);

int [,] FillArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows,columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j< columns; j++)
        {
            array[i,j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

Console.WriteLine("Введите номер строки");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int n = Convert.ToInt32(Console.ReadLine());

if (m > rows || n > columns)
{
    Console.WriteLine("Такого элемента в массиве нет.");
}
else
{
    Console.WriteLine($"Значение элемента строки № {m} и столбца № {n} равно {array[m-1,n-1]}.");
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.WriteLine("]");
    }
}