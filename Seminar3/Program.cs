// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

System.Console.Write("Enter number X :");
int numX = int.Parse(Console.ReadLine());

System.Console.Write("Enter number Y :");
int numY = int.Parse(Console.ReadLine());

if (numX > 0 && numY > 0)
{
    System.Console.WriteLine("1 section");
}
else if (numX < 0 && numY > 0)
{
    System.Console.WriteLine("2 section");
}
else if (numX < 0 && numY < 0)
{
    System.Console.WriteLine("3 section");
}
else if (numX > 0 && numY < 0)
{
    System.Console.WriteLine("4 section");
}
else
{
    System.Console.WriteLine("0 section");
}



// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
int numPalindrome = SetNumber("Palindrome");

//
bool isPalindrome = IsPalindromeInt(numPalindrome);

//

// bool isPalindrome = IsPalindromeString(numPalindrome.ToString());

string str = isPalindrome ? "является палиндромом" : "не является палиндромом";


if (isPalindrome)
{
    str = "является палиндромом";
}

else
{
    str = "не является палиндромом";
}

System.Console.WriteLine($"число {numPalindrome} {str}");
/*конец*/

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
int x1 = SetNumber("x1");
int y1 = SetNumber("y1");
int z1 = SetNumber("z1");
int x2 = SetNumber("x2");
int y2 = SetNumber("y2");
int z2 = SetNumber("z2");

double result = DistanceBetween3DPoints(x1, x2, y1, y2, z1, z2);

System.Console.WriteLine($"result {result}");
/*конец*/

// Задача 23  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3-> 1, 8, 27
// 5-> 1, 8, 27, 64, 125
int num = SetNumber("N");

int[] arr = CubeTable(num);

System.Console.WriteLine(String.Join(",", arr));

/*конец*/

// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
bool IsPalindromeInt(int num)
{
    // num = 456654
    int temp = num;
    // temp = 456654
    int revert = 0;

    while (temp > 0)
    {
        //revert= 0*10=0 + 4=4
        //revert= 4*10=40 + 5=45
        //revert= 45*10=450 + 6=456
        //revert= 456*10=4560 + 6=4566
        //revert= 4566*10=45660 +5=45665
        //revert= 45665*10=456650 + 6=456654
        revert = (revert * 10) + (temp % 10);

        //temp = 45665
        //temp = 4566
        //temp = 456
        //temp = 45
        //temp = 4
        temp /= 10;

    }

    return revert == num;
}

bool IsPalindromeString(string str)
{
    int size = str.Length;
    for (int i = 0; i <= size / 2; ++i)
    {
        if (str[i] != str[size - 1 - i])
        {
            return false;
        }
    }
    return true;
}
// конец
//Задача 21 . Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

double DistanceBetween3DPoints(int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}
// конец

// Задача 23  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int[] CubeTable(int n)
{
    int[] arr = new int[n];

    for (int i = 1; i <= n; i++)
    {
        arr[i - 1] = i * i * i;
    }

    return arr;
}

// конец




//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
void DistanceBetweenPoints(int x1, int x2, int y1, int y2)
{
    double distanceBetweenPoints = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

    Console.WriteLine($"Distance Between Points={distanceBetweenPoints:f2}");
}


// Напишите программу, которая принимает на вход число A
// и выдаёт сумму чисел от 1 до A

Console.Write("Введите число: ");
int limit = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма чисел от 1 до {limit} равна {GetSum(limit)}");

int GetSum(int limit)
{
    int sum = 0;
    for (int i = 1; i <= limit; i++)
        sum += i;
    return sum;
}