﻿// Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. 
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно



Console.Write("Введите число 1 ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2 ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (0 == firstNumber % secondNumber)
{
    Console.Write("Кратно");
}
else if (firstNumber != firstNumber / secondNumber)
{
    Console.WriteLine("Не кратно " + firstNumber % 10); 
}











