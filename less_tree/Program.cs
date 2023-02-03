// goto sec;

// Task Nineteen
int[] palinums = { 14212, 12821, 23432, 1246, 320213 };
foreach (int n in palinums)
{
    if (Convert.ToString(n).Length == 5)
    {
        Char[] queue = new char[5];
        int i = 0;
        foreach (char c in Convert.ToString(n))
        {
            queue[i] = c;
            i++;
        }
        i = 0;
        for (; i < (queue.Length / 2);)
        {
            if (queue[i] == queue[queue.GetUpperBound(0) - i])
                i++;
            else
                break;
        }
        System.Console.Write($"{n}? :");
        if (i == 2)
            System.Console.Write("да \n");
        else
            System.Console.Write("нет \n");
    }
    else
        System.Console.WriteLine($"В числе \"{n}\" не 5 знаков");
}
System.Console.WriteLine();


// task Twenteen one
double[][] xyzAB = new double[2][];
System.Console.Write("Введите координаты(X, Y, Z) точки А через запятую: ");
xyzAB[0] = Console.ReadLine().Split(",").Select(double.Parse).ToArray();
System.Console.Write("Введите координаты(X, Y, Z) точки B через запятую: ");
xyzAB[1] = Console.ReadLine().Split(",").Select(double.Parse).ToArray();
double AB = Math.Sqrt(Math.Pow(xyzAB[1][0] - xyzAB[0][0], 2) +
                    Math.Pow(xyzAB[1][1] - xyzAB[0][1], 2) +
                    Math.Pow(xyzAB[1][2] - xyzAB[0][2], 2));
System.Console.WriteLine($"|AB| = {Math.Round(AB, 2)}");
System.Console.WriteLine();

// sec:
// Task twenteen tree
System.Console.Write("Ведите N: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    System.Console.Write($"{i}^3 = {Math.Pow(i, 3)} \t");
}