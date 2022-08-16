/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

ОГРАНИЧЕНИЯ: нельзя использовать массивы и строки для решения задачи, исключительно работа с циклами и арифметическими опреациями!!!
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();

void CheckingNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"{number} является палиндромом? -> Да!");
  }
  else Console.WriteLine($"{number} является палиндромом? -> Нет!");
}

if (number!.Length == 5)
{
  CheckingNumber(number);
}
else Console.WriteLine($"Некорректный ввод!" + " Необходимо ввести пятизначное число");