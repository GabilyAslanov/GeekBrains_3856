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


//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Enter number : ");
int num = Convert.ToInt32(Console.ReadLine());

// true && true = true    1 * 1 = 1
// false && true = false 0 * 1 = 0
// false && false = false 0 * 0 = 0
// true || true = true  1 + 1 = 1
// true || false = true  1 + 0 = 1
// false || false = false 0 + 0 = 0
if (num > 99 && num < 1000) 
{
    int secondNumber = (num / 10) % 10; //789/10= 78 %10=8

    Console.WriteLine($"Вторая цифра в числе {num} -> {secondNumber}");
}
else
    Console.WriteLine($"Число {num} не трёхзначное");






//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Enter number : ");
num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter index : ");
// int index = Convert.ToInt32(Console.ReadLine());

//ouble pow = Math.Pow(10, index);

//9
if (num < 100)
{
    Console.WriteLine($"Цифра меньше индекса");
  
}
else   {

int tmp = num;

while (tmp > 1000)// 987
{
    tmp /= 10;
}

int result = tmp % 10;

Console.WriteLine($"Цифра под индексом 3 числа {num} -> {result}");
}


//Задача 15: Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Enter dayWeek : ");
string dayWeek = Console.ReadLine();

switch (dayWeek)
{
    case "1":
        Console.WriteLine("Понедельник- НЕТ");
        break;
    case "2":
        Console.WriteLine("Вторник- НЕТ");
        break;
    case "3":
        Console.WriteLine("Среда- НЕТ");
        break;
    case "4":
        Console.WriteLine("Четверг- НЕТ");
        break;
    case "5":
        Console.WriteLine("Пятница- Да");
        break;
    case "6":
        Console.WriteLine("Суббота- Нет");
        break;
    case "7":
        Console.WriteLine("Воскресенье- Нет");
        break;
  default : Console.WriteLine("Такого дня нет") ; break; 
}