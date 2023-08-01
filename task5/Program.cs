Console.WriteLine("Введите число");
int firstNumbernumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = 0 - firstNumbernumber;
int i = secondNumber;
while (i < firstNumbernumber + 1){
    Console.Write(i+ "");
    i++;
}