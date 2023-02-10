// task Twentyfive
double num;
double degree;
double result;

void getResult()
{
    result = num;
    for (int i = 1; i < degree; i++)
    {
        result *= num;
    }
    System.Console.WriteLine(result);
}

System.Console.Write($"Степень числа. \nВведите число:");
num = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write($"Введите степень:");
degree = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write($"Результат {num} ^ {degree} = ");
getResult();
System.Console.WriteLine();

// Task Twentyseven
int sumDigit = 0;
string numsec;
void getNumsec()
{
    numsec = System.Console.ReadLine();
    for (int i = 0; i < numsec.Length; i++)
        sumDigit += Convert.ToInt32(Convert.ToString(numsec[i]));
}
System.Console.Write("Сумма цифр числа.\nВведите число:");
getNumsec();
System.Console.Write($"Сумма цифр числа {numsec} = {sumDigit}");
System.Console.WriteLine();

// Task Twentynine
void randEigthNum(int arrLengt)
{
    int[] numbes = new int[arrLengt];
    var rnd = new Random();
    for (int i = 0; i < arrLengt; i++)
        numbes[i] = rnd.Next(100);
    System.Console.WriteLine($"Ваши числа [{string.Join(", ", numbes)}]");
}
System.Console.WriteLine();
System.Console.Write("Введите размер массива:");
randEigthNum(Convert.ToInt32(System.Console.ReadLine()));
