/*
 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Write("Введите первое число: ");
int NumberA = int.Parse(Console.ReadLine());
Console.Write("Введите  второе число: ");
int NumberB = int.Parse(Console.ReadLine());
if (NumberA > NumberB)
{
    Console.WriteLine("Число " + NumberA + " большее");
    Console.Write("Число " + NumberB + " меньшее");
}
else
{
    Console.WriteLine("Число " + NumberB + " большее");
    Console.Write("Число " + NumberA + " меньшее");
}
