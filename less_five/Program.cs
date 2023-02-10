void generArray(int sizeArray, int start, int end, out int[] array)
{
    array = new int[sizeArray];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(start, end);
}

// Task Thirtyfour
int arrayEvenCheck(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count += 1;
    return count;
}

System.Console.Write("Введите размер массива:");
generArray(Convert.ToInt32(System.Console.ReadLine()), 100, 1000, out int[] array);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
System.Console.Write("Колличество четных чисел = ");
System.Console.WriteLine(arrayEvenCheck(array));
System.Console.WriteLine();

// Task Thirty six
int sumUnevenArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i += 2)
        sum += array[i];
    return sum;
}

System.Console.Write("Введите размер массива:");
generArray(Convert.ToInt32(System.Console.ReadLine()), 0, 100, out array);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
System.Console.Write("Сумма нечетных позиций = ");
System.Console.WriteLine(sumUnevenArray(array));
System.Console.WriteLine();

// Task thirtyeight
void valueMaxMin(int[] array, out int max, out int min)
{
    max = array[0];
    for (int i = 0; i < array.Length; i++) // max num
    {
        if (array[i] > max)
            max = array[i];
    }
    min = max;
    for (int i = 0; i < array.Length; i++) // max min
    {
        if (array[i] < min)
            min = array[i];
    }
}

int diffBetweenValues(int[] array)
{
    valueMaxMin(array, out int max, out int min);
    int diff = max - min;
    return diff;
}

System.Console.Write("Введите размер массива:");
generArray(Convert.ToInt32(System.Console.ReadLine()), 0, 100, out array);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
System.Console.WriteLine($"Разница между максимальным и минимальным элементом = {diffBetweenValues(array)}");
