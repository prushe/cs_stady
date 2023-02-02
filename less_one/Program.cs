using System;
using System.IO;

System.Console.WriteLine("\"Hello\"");

//Task Two
int[] numsA = { 5, 2, -9 };
int[] numsB = { 7, 10, -3 };
int rowLen = (numsA.Length + numsB.Length) / 2;
for (int i = 0; i < rowLen; i++)
{
    System.Console.Write($"{numsA[i]}  \tor {numsB[i]} \t: ");
    if (numsA[i] > numsB[i])
        System.Console.WriteLine(numsA[i]);
    else
        System.Console.WriteLine(numsB[i]);
}

System.Console.WriteLine();
//Task Four
int[,] numbers = new int[3, 3] {
                    { 2, 3, 7 },
                    { 44, 5, 78 },
                    { 22, 3, 9 } };

int rows = numbers.GetUpperBound(0) + 1;
int columns = numbers.GetUpperBound(1) + 1;

for (int i = 0; i < rows; i++)
{
    int maxNumInRow = 0;
    for (int j = 0; j < columns; j++)
    {
        System.Console.Write($"{numbers[i, j]} \t");
        if (maxNumInRow < numbers[i, j])
            maxNumInRow = numbers[i, j];
    }
    System.Console.Write($": {maxNumInRow} \n");
}

System.Console.WriteLine();
//Task Six
int[] chnums = { 4, -3, 7 };
foreach (int n in chnums)
{
    System.Console.Write($"{n}\t== even: ");
    if (n % 2 == 0)
        System.Console.Write("True \n");
    else
        System.Console.Write("False \n");
}

System.Console.WriteLine();
//Task Eight
int[] evenNumsInNums = { 5, 8 };
foreach (int numer in evenNumsInNums)
{
    System.Console.Write($"in {numer} :");
    for (int i = 2; i <= numer; i += 2)
    {
        System.Console.Write($"\t{i}");
    }
    System.Console.WriteLine();
}
