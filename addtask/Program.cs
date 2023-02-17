void generArray(int sizeArray, int start, int end, out int[] array)
{
    array = new int[sizeArray];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++) 
        array[i] = rnd.Next(start, end);
}
int[] multiArray(int[] array)
{
    int[] multi = new int[array.Length / 2 + array.Length % 2];
    if (array.Length % 2 == 1) 
        multi[multi.Length - 1] = array[multi.Length - 1];
    for (int i = 0; i < array.Length / 2; i++) 
        multi[i] = array[i] * array[array.GetUpperBound(0) - i];
    return multi;
}
System.Console.Write("Введите размер массива:");
generArray(Convert.ToInt32(System.Console.ReadLine()), start: 0, end: 10, out int[] array);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
System.Console.Write("Перемножение внутри массива = ");
System.Console.WriteLine($"[{string.Join(", ", multiArray(array))}]");
