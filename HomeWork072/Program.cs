// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


int[,] arr = FillMatrix(10,10);
PrintMatrix(arr);
Console.WriteLine("Введите строку: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец: ");
int y = Convert.ToInt32(Console.ReadLine());

if(x > arr.GetLength(0) || y > arr.GetLength(1) || x == 0 || y == 0)
{
    Console.WriteLine($"{x}, {y} -> Такого числа нет в массиве");
}
int num = arr[x - 1, y - 1];
Console.WriteLine($"число -> {num}");

int[,] FillMatrix(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 99);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}, ");
        }
        Console.WriteLine();
    }
}