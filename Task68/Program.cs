/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/

int M = InputNumbers("Введите M: ");
int N = InputNumbers("Введите N: ");

int functionAkkerman = Ack(M, N);

Console.Write($"N = {N}; M = {M}; => A(M,N) = {functionAkkerman} ");

int Ack(int M, int N)
{
  if (M == 0) return N + 1;
  else if (N == 0) return Ack(M - 1, 1);
  else return Ack(M - 1, Ack(M, N - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}