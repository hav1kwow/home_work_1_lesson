﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число 1 ");
int firstNumber = Convert.ToInt32(Console.ReadLine());


if (firstNumber % 2!=0)
{
    Console.Write("Нет");
}
else
{
Console.Write("Да");
}   