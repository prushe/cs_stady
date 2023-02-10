// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// После загрузки задания, вы можете проверить себя самостоятельно с помощью эталонного решения

// task Twentyfive
double num;
double degree;
double result;

void getNum()
{
    num = Convert.ToInt32(System.Console.ReadLine());
}

void getDegree()
{
    degree = Convert.ToInt32(System.Console.ReadLine());
}

void getResult()
{
    result = Math.Pow(num, degree);
    System.Console.WriteLine(result);
}

System.Console.Write($"Степень числа. \nВведите число:");
getNum();
System.Console.Write($"Введите степень:");
getDegree();
System.Console.Write($"Результат {num} ^ {degree} = ");
getResult();
System.Console.WriteLine();

// Task Twentyseven
int sumDigit = 0;
string numsec;
void getNumsec()
{
    numsec = System.Console.ReadLine();
    for (int i = 0; i < numsec.Length; i ++)
    {
        sumDigit += Convert.ToInt32(Convert.ToString(numsec[i])); 
    }

}
System.Console.Write("Сумма цифр числа.\nВведите число:");
getNumsec();
System.Console.Write($"Сумма цифр числа {numsec} = {sumDigit}");
