// Напишите программу, которая выводит случайное 
// трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Random rand = new Random();
int number = rand.Next(100, 1000);
Console.WriteLine(number);
int a = number / 100;
int b = number % 10;
String s1 = a.ToString();
String s2 = b.ToString();
string Result = s1 + s2;
Console.WriteLine(Result);
