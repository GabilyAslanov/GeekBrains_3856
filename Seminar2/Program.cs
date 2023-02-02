// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
int number = new Random().Next(10, 100);

int number1 = number / 10;//58 5
int number2 = number % 10;//48 8

Console.WriteLine($"number  = {number}");
if (number1 > number2)
{
    Console.WriteLine($"number1 = {number1} больше number2= {number2}");
}
else if (number1 < number2)
{
    Console.WriteLine($"number2 = {number2} больше number1 = {number1} ");
}
else
{
    Console.WriteLine($"number1 равно number2");
}