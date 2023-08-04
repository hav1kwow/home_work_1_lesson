// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberr = Convert.ToString(anyNumber);

if (anyNumberr.Length > 2){
    Console.Write("anyNumber " + anyNumberr[2]);
}
else{
    Console.Write("Третьей цифры нет");
}

