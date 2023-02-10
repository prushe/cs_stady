// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Task Thirtyfour
void generArray(int sizeArray, int start, int end, out int[] array)
{
    array = new int[sizeArray];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(start, end);
}

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
generArray(Convert.ToInt32(System.Console.ReadLine()), 0, 1000, out array);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
System.Console.Write("Сумма нечетных позиций = ");
System.Console.WriteLine(sumUnevenArray(array));
System.Console.WriteLine();

// Task thirtyeight
