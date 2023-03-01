int IntInput(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int summ = 0;
int Summ(int m, int n)
{
    summ += m;
    if (m == n) return summ;
    else return Summ(m + 1, n);
}
System.Console.WriteLine("\"Сумма\"");
int m = IntInput("Введите M:");
int n = IntInput("Введите N:");
System.Console.WriteLine($"сумма элементов от {m} до {n} = {Summ(m, n)}");
System.Console.WriteLine();

int aker(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return aker(m - 1, 1);
    else return aker(m - 1, aker(m, n - 1));
}
System.Console.WriteLine("\"функции Аккермана\"");
m = IntInput("Введите M:");
n = IntInput("Введите N:");
System.Console.WriteLine($"функция A({m},{n}) = {aker(m, n)}");
