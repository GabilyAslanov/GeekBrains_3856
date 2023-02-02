// // Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
// // на само себя).

// // Например:
// // 4 -> 16 
// // -3 -> 9 
// // -7 -> 49

// Console.Write("Enter number :");

// string strNumber = Console.ReadLine();

// int number = Convert.ToInt32(strNumber);

// int sqr = number * number;

// Console.WriteLine(sqr);


// //Напишите программу, 
// //которая будет выдавать название дня недели по заданному номеру.

// Console.Clear();

// Console.Write("Введите номер дня недели: ");

// int numberDayOfWeek=Convert.ToInt32(Console.ReadLine());



// if(numberDayOfWeek==1)
// {
//     Console.WriteLine("Понедельник");
// }
// else if(numberDayOfWeek==2)
// {
//     Console.WriteLine("Вторник");
// }
// else if(numberDayOfWeek==3)
// {
//     Console.WriteLine("Среда");
// }
// else if(numberDayOfWeek==4)
// {
//     Console.WriteLine("Четверг");
// }
// else if(numberDayOfWeek==5)
// {
//     Console.WriteLine("Пятница");
// }
// else if(numberDayOfWeek==6)
// {
//     Console.WriteLine("Суббота");
// }
// else if(numberDayOfWeek==7)
// {
//     Console.WriteLine("Воскресенье");
// }
// else
// {
//     Console.WriteLine("Введен неправильный номер");
// }
// string str = "number Day Of Week";

// switch(Console.ReadLine())
// {
// case "1": Console.WriteLine("Monday"); break;

// case "2": Console.WriteLine("Tuesday"); break;

// case "3": Console.WriteLine("Wednesday"); break;

// case "numberDayOfWeek": Console.WriteLine("numberDayOfWeek"); break;

// case "number Day Of Week": Console.WriteLine("number "); break;

// default: Console.WriteLine("Bad number");  break;
// }


// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8
Console.Write("Введите номер : ");

int number3 = Convert.ToInt32(Console.ReadLine());

int result = number3 / 10;

System.Console.WriteLine(result);


//Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

Console.Clear();
Console.Write("Введите A: ");
string? strNumber1 = Console.ReadLine();
int number1;
Console.Write("Введите B: ");
int number2 = int.Parse(Console.ReadLine());
if (int.TryParse(strNumber1, out number1))
{


    if (number1 > number2)
    {
        Console.WriteLine("A больше B");
    }
    else if (number1 < number2)
    {
        Console.WriteLine("B больше A");
    }
    else
    {
        Console.WriteLine("A равно B");
    }

}





//Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.

Console.Clear();
Console.Write("Введите первое чило: ");
number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
number2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
number3 = int.Parse(Console.ReadLine());

int max = number1; // 10

if (max < number2)//-10
{
    max = number2;
}
if (max < number3)//15
{
    max = number3;
}

Console.WriteLine($"максимальное число = {max} {number1} {number2} {number3} ");

//Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}

//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());

//Первое решение
int i = 1;
while (i <= N)//N=-15
{
    if (i % 2 == 0)
    {
        Console.Write($"{i} ");
        
    }
    
    i++;

    
}
Console.WriteLine();

//Второе решение
int k = 2;
while (k <= N)
{
    Console.Write($"{k} ");
    k += 2;
}
