Console.Write("Введите число 1 ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2 ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber * secondNumber)
{
    Console.Write("Да");
}
else
{
Console.Write("Нет");
}