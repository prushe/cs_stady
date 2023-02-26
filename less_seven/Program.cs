// task Fourti seven
double[,] GenerateArray(int m, int n)
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
void PrintArray(double[,] array)
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

double[,] myArray = GenerateArray(3, 4);
PrintArray(myArray);
