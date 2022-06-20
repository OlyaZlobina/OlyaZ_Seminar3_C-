// Задача 19: *Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine(" Input five digit number: ");
int fiveDNum = Convert.ToInt32(Console.ReadLine());
void Palindrom(){
    int num1 = fiveDNum / 10000 % 10;
    Console.Write(num1);
    int num2 = fiveDNum / 1000 % 10;
    Console.Write(num2);
    int num4 = fiveDNum / 10 % 10;
    Console.Write(num4);
    int num5 = fiveDNum % 10;
    Console.WriteLine(num5);
    if (num1 == num5 && num2 == num4)
    {
        Console.WriteLine(fiveDNum + "Number is a palindrom");
    }
    else
    {
        Console.WriteLine("Number is not a palindrom");
    }
}
Palindrom();
