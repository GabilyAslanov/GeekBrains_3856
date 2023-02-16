// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

System.Console.Write("Enter number A :");
int numA = int.Parse(Console.ReadLine());



if (numA < 1)
{
    System.Console.WriteLine("Число меньше 1");
}
else
{
    int result = GetSum(numA);
    System.Console.WriteLine($"sum =  {result}");
    System.Console.WriteLine($"sum =  {GetSum(numA)}");
}


int GetSum(int number)
{
    int sum = 0;

    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }

    return sum;
}


//HW
Start();

void Start()
{
    while (true)
    {
        Console.ReadLine();
        Console.Clear();

        System.Console.WriteLine("25) Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
        System.Console.WriteLine("27) Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
        System.Console.WriteLine("29) Задача 29: Напишите программу, которая задаёт массив из введенного числа и выводит их на экран.");
        System.Console.WriteLine("0) End");

        int numTask = SetNumber("task");

        switch (numTask)
        {
            case 0: return; break;
            case 25: MyPow(); break;
            case 27: SumNumbers(); break;
            case 29: ViewArray(); break;
            default: System.Console.WriteLine("error"); break;
        }
    }
}
//Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

void MyPow()
{

    Console.Clear();

    int num = SetNumber("");

    int degree = SetNumber("degree of");

    Console.WriteLine($"{num} в степени {degree} = {Pow(num, degree)}");
}



int Pow(int num, int rank)
{
    if (rank == 0) return 1;
    else if (rank == 1) return num;

    int result = num;

    for (int i = 2; i <= rank; i++)
    {
        result *= num;
    }

    return result;
}
//end

//Напишите программу, которая принимает 
//на вход число N и выдаёт сумму цифр в числе.
void SumNumbers()
{
    Console.Clear();

    int num = SetNumber("N");
    Console.WriteLine($"Суммф цифр = {GetSumNums(num)}");
}


int GetSumNums(int number)
{
    int sum = 0;

    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }

    return sum;
}
//end

//Напишите программу, которая задаёт массив 
//из 8 элементов и выводит их на экран.
void ViewArray()
{

    Console.Clear();
    int size = SetNumber("size");
    int minValue = SetNumber("minValue");
    int maxValue = SetNumber("maxValue");
    int[] array = GetRandomArray(size, minValue, maxValue);
    Console.WriteLine($"[{String.Join(",", array)}]");
}


int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }

    return result;
}
//end
int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

//end


//Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());

//Console.WriteLine($"Cумма цифр = {GetSumNums2(num)}");


int GetSumNums1(int number)
{
    //1+1
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

int GetSumNums2(int number)
{
    int result = 0;

    for (int i = 1; i <= number; i++)
    {
        result += i;
    }

    return result;

}
/*конец*/

//Напишите программу, которая принимает 
//на вход число N и выдаёт количество цифр в числе.

// Console.Write("Введите число: ");
// num = int.Parse(Console.ReadLine());
//Console.WriteLine($"Количество цифр = {GetCountNums(num)}");


int GetCountNums(int number)
{
    int count = 0;
    while (number > 0)
    {
        count++;
        number /= 10;
    }
    return count;
}
/*конец*/

//Напишите программу, которая принимает 
//на вход число N и выдаёт произведение чисел от 1 до N.

// Console.Write("Введите число: ");
// num = int.Parse(Console.ReadLine());
// Console.WriteLine($"Произведение цифр = {GetMultiply(num)}");


int GetMultiply(int number)
{
    int result = 1;
    for (int i = 2; i <= number; i++)
    {
        result *= i;
    }
    return result;
}
/*конец*/

//Напишите программу, которая выводит массив из 8 элементов,
//заполненный нулями и единицами в случайном порядке.

// int[] array = GetBinaryArray(8);
// Console.WriteLine($"[{String.Join(",", array)}]");


int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(2);
    }

    return result;
}
/*конец*/