// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/* 
double[,] GetArr(int m, int n)
{
    double[,] result = new double[m, n];
    for (int i =0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().NextDouble();
        }       
    }
    return result;
}

void PrintArr(double[,] arr)
{
    for (int i =0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j <arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }     
        Console.WriteLine();  
    }
}

PrintArr(GetArr(3,4));
 */

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
/* 
Console.Write("Введите индекс строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: "); 
int colums = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[3, 4];

void GetArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
             Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

GetArr(arr);
PrintArr(arr);

if (rows < arr.GetLength(0) && colums < arr.GetLength(1)) Console.WriteLine(arr[rows, colums]);
else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");
 */


// Задание 52 Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.

/* 
int[,] numbers = new int[3,4];

void GetArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintResult(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

GetArray(numbers);
PrintArr(numbers);

double[] avgNumbers = new double[numbers.GetLength(1)];

for (int i = 0; i < numbers.GetLength(1); i++)
{
    double result = 0.0;
    for (int j = 0; j < numbers.GetLength(0); j++)
    {
        result += numbers[j, i];
    }
    avgNumbers[i] = result / numbers.GetLength(0);
}

PrintResult(avgNumbers);
 */