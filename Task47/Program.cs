/*
 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            result[i, j] = new Random().Next(-100, 100);
    return result;
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

int[,] myArray = GetArray(3, 4, 0, 100);
PrintArray(myArray);