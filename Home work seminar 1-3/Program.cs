// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число 1 ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

    
for (int i = 1; i <= firstNumber; i++)
    if (i % 2 == 0)
        Console.WriteLine(i);