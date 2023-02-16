// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// 

int numRows = SetNumber("Rows");

int numColumns = SetNumber("Columns");

int numMaxValue = SetNumber("Max Value");

int numMinValue = SetNumber("Min Value");

var matrix = GetMatrix(numRows, numColumns, numMinValue, numMaxValue);
Print(matrix);

int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


int[,] GetMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix[i, l] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void Print(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            System.Console.Write(matrix[i, l] + " ");
        }
        System.Console.WriteLine();
    }
}


double FibonacciBad(int n)
{
	if(n == 1 || n == 2) return 1;
	else return FibonacciBad(n-1) + FibonacciBad(n-2);
}

double FibonacciR(double[] f, int n)
{
	if(n == 1 || n == 2) 
    {
        return f[n-1] = 1;
    }
	else
    {
        if(f[n-2]!=0)
        {
            if(f[n-1]!=0)
                return f[n-1] = f[n-2] + f[n-3];
            else
                return  f[n-1] = FibonacciR(f, n-1) + f[n-3];
        }
        else
            return f[n-1] = FibonacciR(f, n-1) + FibonacciR(f, n-2);
    }
}
double FibonacciGood(int n)
{
    
    double[] f = new double[n];
    return FibonacciR(f, n);
}


int countTests = 40;


DateTime saveTime;

Console.WriteLine($"Цикл for: ");
saveTime = DateTime.Now;
int fibonacci1 = 1;
int fibonacci2 = 1;
for (int i = 1; i <= countTests; i++)
{
	Console.WriteLine($"f({i}) = {fibonacci2}");
	int temporary = fibonacci2;
	fibonacci2 += fibonacci1;
	fibonacci1 = temporary; 
}
Console.WriteLine($"Для for прошло: {DateTime.Now - saveTime}");


Console.WriteLine($"FibonacciBad: ");
saveTime = DateTime.Now;
for (int i = 1; i <= countTests; i++)
{

	Console.WriteLine($"F({i}) = {FibonacciBad(i)}");
}
Console.WriteLine($"Для FibonacciBad прошло: {DateTime.Now - saveTime}");


Console.WriteLine($"FibonacciGood: ");
saveTime = DateTime.Now;
for (int i = 1; i <= countTests; i++)
{

	Console.WriteLine($"F({i}) = {FibonacciGood(i)}");
}
Console.WriteLine($"Для FibonacciR прошло: {DateTime.Now - saveTime}");