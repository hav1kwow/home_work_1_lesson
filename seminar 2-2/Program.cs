﻿
// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.Write("Введите число 1 ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2 ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber * secondNumber || secondNumber == firstNumber * firstNumber)
{
    Console.Write("Да");
}
else
{
Console.Write("Нет");
}

