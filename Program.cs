// Task 1. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.


// int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i,j] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

void Show2dArray(int[,] array)

{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Task 1. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j.
// Выведите полученный массив на экран.

// int[,] Create2dArray(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = i + j;
//     return array;
// }
// Console.Write("Input a quantity of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a quantity of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2dArray(rows, columns);
// Show2dArray(myArray);

// Task 2. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// void
void Create2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i+=2)
        for (int j = 0; j < array.GetLength(1); j+=2)
        {
            array[i, j] = array[i, j] * array[i, j];
        }
}

Console.Write("Input a quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

Create2dArray(array);
Show2dArray(array);


// Task 3. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
// (с индексами (0,0); (1;1) и т.д.