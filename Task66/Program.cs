/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Write("Введи N: ");
int N = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи M: ");
int M = Convert.ToInt16(Console.ReadLine());
int temp = M;

if (M> N) 
{
  M = N; 
  N = temp;
}

PrintSumm(M, N, temp=0);

void PrintSumm(int N, int M, int summ)
{
  summ = summ + N;
  if (N <= M)
  {
    Console.Write($"N = {N}; M = {M}; ->  {summ} ");
    return;
  }
  PrintSumm(M, N - 1, summ);
}
