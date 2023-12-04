// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3



Console.Clear();
int rows = UserNumber("Введите количество строк массива: ", "Ошибка ввода! ");
int columns = UserNumber("Введите количество столбцов массива: ", "Ошибка ввода! ");
int min = UserNumber("Введите минимальное значение массива: ", "Ошибка ввода! ");
int max = UserNumber("Введите максимальное значение массива: ", "Ошибка ввода! ");
int[,] array = GetArray(rows, columns, min, max);
PrintArray(array);
NewPrintArray(array);

int UserNumber(string message, string errormessage)
{
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int num))
        return num;
        Console.Write(errormessage);
    }
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(min, max+1);
        }
    }
    return result;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void NewPrintArray(int[,] arr)
{
    for (int j = 0; j < array.GetLength(1); j++)
{
    double average = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        average += array[i,j]; 
    }
    average /= rows;
    Console.Write($"{average}; ");
}
}

// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
double rows = UserNumber("Введите количество строк массива: ", "Ошибка ввода! ");
double columns = UserNumber("Введите количество столбцов массива: ", "Ошибка ввода! ");
double min = UserNumber("Введите минимальное значение массива: ", "Ошибка ввода! ");
double max = UserNumber("Введите максимальное значение массива: ", "Ошибка ввода! ");
double[,] array = GetArray(rows, columns, min, max);
PrintArray(array);


int UserNumber(string message, string errormessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int num))
            return num;
        Console.Write(errormessage);
    }
}
double[,] GetArray(double m, double n, double min, double max)
{
    double[,] result = new double[(int)m, (int)n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
             
            result[i, j] = new Random().NextDouble();
        }
    }
    return result;
}
void PrintArray(double [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

// Напишите программу, которая 
// на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1;7 -> такого числа в массиве нет

using System.Data;

Console.Clear();
int rows = UserNumber("Введите номер строки массива, чтобы проверить есть она в заданном массиве или нет: ", "Ошибка ввода! ");
int columns = UserNumber("Введите номер столбца массива, чтобы проверить есть она в заданном массиве или нет: ", "Ошибка ввода! ");

int[,] array = GetArray(5, 5, 0, 9);
PrintArray(array);

if (rows > array.GetLength(0) || columns > array.GetLength(1))
{
    Console.WriteLine("Tакого элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента [{rows};{columns}] равно {array[rows-1,columns-1]}");
}

int UserNumber(string message, string errormessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int num))
            return num;
        Console.Write(errormessage);
    }
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}


void PrintArray(int[,] arr)
{
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");

        }
        Console.Write("]");
        Console.WriteLine();
    }
}

