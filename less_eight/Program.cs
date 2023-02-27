// task fivetin four
int[,] GenerateInt2DArray(int m, int n, int maxx)
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
void PrintInt2DArray(int[,] array)
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
int[,] myInt2DArray = GenerateInt2DArray(4, 10, 101);
PrintInt2DArray(myInt2DArray);
myInt2DArray = Arrange(myInt2DArray);
PrintInt2DArray(myInt2DArray);
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
myInt2DArray = GenerateInt2DArray(6, 2, 100);
PrintInt2DArray(myInt2DArray);
MinAverageLine(myInt2DArray);
System.Console.WriteLine();

// task fivetin eight
int[,] MtrixMultiply(int[,] myInt2DArrayOne, int[,] myInt2DArrayTwo)
{
    int[,] result = new int[myInt2DArrayOne.GetLength(0), myInt2DArrayTwo.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = myInt2DArrayOne[i, 0] * myInt2DArrayTwo[0, j] + myInt2DArrayOne[i, 1] * myInt2DArrayTwo[1, j];
        }
    }
    return result;
}
int[,] myInt2DArrayOne = GenerateInt2DArray(2, 2, 10);
int[,] myInt2DArrayTwo = GenerateInt2DArray(2, 2, 10);
PrintInt2DArray(myInt2DArrayOne);
PrintInt2DArray(myInt2DArrayTwo);
int[,] resultIntArray = MtrixMultiply(myInt2DArrayOne, myInt2DArrayTwo);
PrintInt2DArray(resultIntArray);
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
