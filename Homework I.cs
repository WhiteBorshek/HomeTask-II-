/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 
*/
Console.WriteLine("Введите число");
string number = Console.ReadLine();
int num = Convert.ToInt32(number);
int b=num/10%10;

    Console.Write(b);
