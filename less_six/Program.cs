// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int[] ReadIntList(string consoleText)
{
    System.Console.Write(consoleText);
    int[] list = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
    return list;
}
int MoreZero(int[] numList)
{
    int count = 0;
    foreach (int item in numList)
    {
        if (item > 0)
        {
            count++;
        }
    }
    return count;
}
int[] numList = ReadIntList("enter numbers separated by comanns: ");
System.Console.WriteLine("numbers more zero: " + MoreZero(numList));
System.Console.WriteLine();

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
int ReadIntNum(string consoleText)
{
    System.Console.Write(consoleText);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
double[] CrsossFunction(double b1, double b2, double k1, double k2) //y = k1 * x + b1, y = k2 * x + b2
{
    double[] xy = new double[2];
    xy[0] = (b2 - b1) * -1 / (k2 - k1);
    System.Console.WriteLine(xy[0]);
    xy[1] = k1 * xy[0] + b1;
    return xy;
}
int b1 = ReadIntNum("enter b1:");
int b2 = ReadIntNum("enter b2:");
int k1 = ReadIntNum("enter k1:");
int k2 = ReadIntNum("enter k2:");
double[] CrossPointsXY = CrsossFunction(b1, b2, k1, k2);
System.Console.WriteLine($"intersection point ({CrossPointsXY[0]},{CrossPointsXY[1]})");
