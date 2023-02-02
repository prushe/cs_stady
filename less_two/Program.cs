// Task Teen
int[] secNum = { 456, 782, 918 };
foreach (int i in secNum)
{
    System.Console.WriteLine(i / 10 % 10);
}
System.Console.WriteLine();

// Task thirteen
int[] thirdNum = { 645, 78, 32679 };

// option ONE
foreach (int num in thirdNum)
{
    int i = num;
    if (Convert.ToString(num).Length <= 2)
        System.Console.WriteLine("третьей цифры нет");
    else
    {
        if (Convert.ToString(i).Length > 3)
        {
            do
            {
                i = i / 10;
            }
            while (Convert.ToString(i).Length > 3);
            System.Console.WriteLine(i % 10);
        }
        else
        {
            System.Console.WriteLine(i % 10);
        }

    }


}
System.Console.WriteLine();

// option TWO
int queue = 0;
foreach (var num in thirdNum)
    if (Convert.ToString(num).Length == 2)
        System.Console.WriteLine("третьей цифры нет");
    else
        foreach (var i in Convert.ToString(num))
        {
            queue++;
            if (queue >= 3)
            {
                System.Console.WriteLine(i);
                queue = 0;
            }

        }
System.Console.WriteLine();

// task fifteen
System.Console.Write("Количество проверок: ");
int iter = Convert.ToInt32(Console.ReadLine());
for (; iter >= 1; iter--)
{
    System.Console.Write("Порядковый номер вашего дня: ");
    int day = Convert.ToInt32(System.Console.ReadLine());
    if (day < 6)
        System.Console.Write("нет \n");
    else
        System.Console.Write("да \n");
    System.Console.WriteLine();
}