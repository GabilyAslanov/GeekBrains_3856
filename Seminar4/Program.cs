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