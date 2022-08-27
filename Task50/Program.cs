/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
m = 1, n =7 -> такого числа в массиве нет
*/

Console.Write("Введите номер строки: ");
bool inputFirst = int.TryParse(Console.ReadLine(), out int
numberRows);

Console.Write("Введите номер столбца: ");
bool inputSecond = int.TryParse(Console.ReadLine(), out int
numberColumns);

if (inputFirst && inputSecond)
{
    int[,] randomArray = GetFillArray(3, 4);
    PrintArray(randomArray);
    Console.WriteLine();
    FindElementPosition(randomArray, numberRows, numberColumns);
}
else Console.WriteLine($"Некорректный ввод!");


int[,] GetFillArray(int m, int n)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            result[i, j] = new Random().Next(10);
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindElementPosition(int[,] array, int positionRows, int positionColumns)
{
    if (positionRows < array.GetLength(0) && positionColumns < array.GetLength(1))
    {
        Console.WriteLine($"На позиции строка № {positionRows}, столбец № {positionColumns} " +
                          $"находится элемент со значением: {array[positionRows - 1, positionColumns - 1]}");
    
    }
    else Console.WriteLine($"Cтрока № {positionRows}, столбец № {positionColumns} - такой позиции в массиве нет.");
}
