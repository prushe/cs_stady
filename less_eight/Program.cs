goto strt;
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
int[,] Arrange(int[,] array)
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
myIntArray = Arrange(myIntArray);
PrintIntArray(myIntArray);
System.Console.WriteLine();

strt:
// task fivetin six
int[] AverageLine(int[,] array)
{
    int[] averageLine = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            averageLine[i] += array[i, j];
        }
        averageLine[i] = averageLine[i] / array.GetLength(1);
    }
    return averageLine;
}
int Min(int[] array)
{
    int position = 0;
    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        if (array[position] > array[i + 1])
            position = i + 1;
    }
    return position + 1;
}
void MinAverageLine(int[,] array)
{
    int[] averageLine = AverageLine(array);
    int minLine = Min(averageLine);
    System.Console.WriteLine($"Строка с наименьшим средним арифметическим под №{minLine}");
}
myIntArray = GenerateIntArray(6, 2);
PrintIntArray(myIntArray);
MinAverageLine(myIntArray);
