// task fivetin four
int[,] GenerateIntArray(int m, int n)
{
    Random rand = new Random();
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(0, 101);
        }
    }
    return array;
}
void PrintIntArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
int[,] arrange(int[,] array)
{
    for (int ic = 0; ic < array.GetLength(1) / 2 + 1; ic++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[i, j] >= array[i, j + 1])
                {
                    array[i, j] = array[i, j];
                    array[i, j + 1] = array[i, j + 1];
                }
                else
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                }
            }
        }
    }
    return array;
}
int[,] myIntArray = GenerateIntArray(4, 10);
PrintIntArray(myIntArray);
myIntArray = arrange(myIntArray);
PrintIntArray(myIntArray);
System.Console.WriteLine();
