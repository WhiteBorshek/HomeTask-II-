/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.WriteLine("Введите число");
string number = Console.ReadLine();
int num = Convert.ToInt32(number);
if (num < 6 && num < 7)
{
    Console.WriteLine("Этот день недели не выходной");
}
else
{
    Console.WriteLine("Этот день недели выходной");
}
