/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.WriteLine("Количество строк в массиве: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Количество столбцов в массиве: ");
int n = int.Parse(Console.ReadLine());
double[,] myArray = new double[m, n];
FillArray(myArray);
PrintArray(myArray);

void FillArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine("]");
    }
}