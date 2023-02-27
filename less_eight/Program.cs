goto strt;
// task fivetin four
int[,] GenerateIntArray(int m, int n, int maxx)
{
    Random rand = new Random();
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(0, maxx);
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
int[,] myIntArray = GenerateIntArray(4, 10, 101);
PrintIntArray(myIntArray);
myIntArray = Arrange(myIntArray);
PrintIntArray(myIntArray);
System.Console.WriteLine();

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
myIntArray = GenerateIntArray(6, 2, 100);
PrintIntArray(myIntArray);
MinAverageLine(myIntArray);
System.Console.WriteLine();

// task fivetin eight
int[,] MtrixMultiply(int[,] myIntArrayOne, int[,] myIntArrayTwo)
{
    int[,] result = new int[myIntArrayOne.GetLength(0), myIntArrayTwo.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = myIntArrayOne[i, 0] * myIntArrayTwo[0, j] + myIntArrayOne[i, 1] * myIntArrayTwo[1, j];
        }
    }
    return result;
}
int[,] myIntArrayOne = GenerateIntArray(2, 2, 10);
int[,] myIntArrayTwo = GenerateIntArray(2, 2, 10);
PrintIntArray(myIntArrayOne);
PrintIntArray(myIntArrayTwo);
int[,] resultIntArray = MtrixMultiply(myIntArrayOne, myIntArrayTwo);
PrintIntArray(resultIntArray);
System.Console.WriteLine();

//task sixteen
int[,,] GenerateInt3DArray(int m, int n, int h, int maxx)
{
    Random rand = new Random();
    int[,,] array = new int[m, n, h];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int y = 0; y < array.GetLength(2); y++)
            {
                array[i, j, y] = rand.Next(0, maxx);
            }
        }
    }
    return array;
}
void PrintInt3DArray(int[,,] array)
{
    for (int y = 0; y < array.GetLength(0); y++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(2); j++)
            {
                System.Console.Write(array[i, j, y] + $"({i},{j},{y}) \t");
            }
            System.Console.WriteLine();
        }
    }
}
int[,,] myInt3DArray = GenerateInt3DArray(2, 2, 2, 101);
PrintInt3DArray(myInt3DArray);
System.Console.WriteLine();
