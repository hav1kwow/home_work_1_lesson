// Напишите программу, которая выводит случайное число из отрезка 
// [10, 99] и показывает наибольшую цифру числа.
// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8
// Random rand = new Random();
// [10, 99] == 10 99
// (10, 99) != 10 99
//  int n = new Random().Next(10,100)

Random rand = new Random();
int number = rand.Next(10, 100);

int a = number / 10;
int b = number % 10;
Console.WriteLine(number);

if(a > b){
    Console.WriteLine("Маскимальное число a =" + a);
}
else if(b > a){
    Console.WriteLine("Максимальное {1} число b = {0}", b, a);
}
else {
    Console.WriteLine($"Все числа равны {a} = {b}");
}
