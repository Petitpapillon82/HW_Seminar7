/*
Дополнительная задача (задача со звёздочкой): Задайте двумерный массив из целых чисел. 
Определите, есть столбец в массиве, сумма которого, больше суммы элементов расположенных в четырех "углах" двумерного массива.

Например, задан массив:
4 4 7 5
4 3 5 3
8 1 6 8 -> нет

2 4 7 2
4 3 5 3
2 1 6 2 -> да
*/

Console.WriteLine("Зададим двумерный массив случайных целых чисел.");

Console.Write("Количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine());

Console.WriteLine("Полученный массив: ");
int [,] array = FillArray(rows, columns, 1 , 10);
PrintArray(array);
FindMaxSum(array);
FindCornerElements(array);
// int sumCornerElement = int.Parse(Console.ReadLine()); - осталось всего ничего - сравнить два результата, но не могу сообразить как
// int maxSum = int.Parse(Console.ReadLine());
// if (maxSum > sumCornerElement)
// {
//    Console.WriteLine("В массиве есть столбец, сумма которого больше суммы его угловых элементов"); 
// }
// if (maxSum <= sumCornerElement)
// {
//    Console.WriteLine("В массиве нет столбца, сумма которого больше суммы его угловых элементов"); 
// }
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

void FindMaxSum(int [,] array) // Поиск столбца с максимальной суммой
{
int idx = 0; // Переменная для хранения индекса
int maxSum = int.MinValue; // Переменная для хранения максимальной суммы
 for(int j = 0; j < columns; j++) 
    {
        int sum = 0;
        for(int i = 0; i < rows; i++)
        {
          sum += array[i, j];
        }
        if (sum < maxSum)
        { 
        idx ++;  
        Console.WriteLine($"Cумма {idx} столбца равна {sum}");
        }
        if (sum > maxSum)
        { 
        maxSum = sum; 
        idx ++;
        Console.WriteLine($"Cумма {idx} столбца равна {sum}");
        }    
    }
    Console.WriteLine($"Максимальная сумма по столбцам равна {maxSum}");
}

void FindCornerElements(int[,] arr)
{
int sumCornerElement = 0;
        {
          int leftTopCorner = array[0, 0]; 
            Console.WriteLine("Верхний крайний левый элемент: " + leftTopCorner);
            int rightTopCorner = array[0,columns - 1];
            Console.WriteLine("Верхний крайний правый элемент: " + rightTopCorner);
            int leftBottomCorner = array[rows - 1, 0];
            Console.WriteLine("Нижний крайний левый элемент: " + leftBottomCorner);
            int rightBottomCorner = array[rows - 1, columns - 1];
            Console.WriteLine("Нижний крайний правый элемент: " + rightBottomCorner);       
sumCornerElement = leftTopCorner + rightTopCorner +leftBottomCorner + rightBottomCorner;

Console.Write($"Сумма угловых элементов равна {sumCornerElement}");
        }
}
