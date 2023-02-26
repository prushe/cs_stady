// task Fourtin seven
double[,] GenerateDoubleArray(int m, int n)
{
    Random rand = new Random();
    double[,] array = new double[m, n];
    for (int i = 0; i <= array.GetUpperBound(0); i++)
    {
        for (int j = 0; j <= array.GetUpperBound(1); j++)
        {
            array[i, j] = rand.Next(-100, 101) / 10.0;
        }
    }
    return array;
}
void PrintDoubleArray(double[,] array)
{
    for (int i = 0; i <= array.GetUpperBound(0); i++)
    {
        for (int j = 0; j <= array.GetUpperBound(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

double[,] myDoubleArray = GenerateDoubleArray(3, 4);
PrintDoubleArray(myDoubleArray);
System.Console.WriteLine();

//task fiveteen
int[,] GenerateIntArray(int m, int n)
{
    Random rand = new Random();
    int[,] array = new int[m, n];
    for (int i = 0; i <= array.GetUpperBound(0); i++)
    {
        for (int j = 0; j <= array.GetUpperBound(1); j++)
        {
            array[i, j] = rand.Next(0, 11);
        }
    }
    return array;
}
void PrintIntArray(int[,] array)
{
    for (int i = 0; i <= array.GetUpperBound(0); i++)
    {
        for (int j = 0; j <= array.GetUpperBound(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
void PrintElementArray(int[,] array, int x, int y)
{
    string print = (x <= array.GetUpperBound(0) && y <= array.GetUpperBound(1)) ? Convert.ToString(array[x, y]) : "такого числа в массиве нет";
    System.Console.WriteLine(print);
}
void ArrayAdress(out int x, out int y)
{
    int[] xy = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
    y = xy[0];
    x = xy[1];
}
void UserMessage(string message)
{
    System.Console.Write(message);
}
int[,] myIntArray = GenerateIntArray(4, 4);
PrintIntArray(myIntArray);
UserMessage("Введите адрес элемента массива через зяпятую (X, Y): ");
ArrayAdress(out int x, out int y);
PrintElementArray(myIntArray, x, y);
System.Console.WriteLine();

// task fivetin two
void ColAverage(int[,] array)
{
    for (int i = 0; i <= array.GetUpperBound(1); i++)
    {
        double colResult = 0;
        for (int j = 0; j <= array.GetUpperBound(0); j++)
        {
            colResult += array[j, i];
        }
        colResult = Math.Round(colResult / (array.GetUpperBound(0) + 1), 2);
        System.Console.Write(colResult + "\t");
    }
}
myIntArray = GenerateIntArray(4, 4);
PrintIntArray(myIntArray);
ColAverage(myIntArray);
