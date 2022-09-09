/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

Console.Write("Среднее арифметическое каждого столбца: ");

for (int j = 0; j < columns; j++)
{
    double average = 0;
    for (int i = 0; i < rows; i++)
    {
        average = (average + array[i, j]);
    }
    average = Math.Round(average / rows, 1);
    
    Console.Write(average + "   ");
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i,j] + "  ");
        }   
        Console.WriteLine("]");
    }
}