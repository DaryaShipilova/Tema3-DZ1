﻿//Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32 (Console.ReadLine ());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32 (Console.ReadLine ());

if (firstNumber > secondNumber)
{
   Console.WriteLine("max = " + firstNumber);
}
else
{
   Console.WriteLine("max = " + secondNumber);
}
