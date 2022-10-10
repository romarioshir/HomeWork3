// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

static void PalindromOrNo(int a)
{
    while (true)
    {
        Console.Write("Введите пятизначное число: ");
        if (int.TryParse(Console.ReadLine(), out a))
            break;
        else
            Console.WriteLine("Ошибка ввода!");
    }
    if (a < 0)
    {
        a = a * -1;
        if (a / 10000 > 0 && a / 10000 < 10)
        {
            if (a / 10000 == a % 10 && (a / 1000) % 10 == (a % 100) / 10)
                Console.WriteLine($"{a} -> да");
            else
                Console.WriteLine($"{a} -> нет");
        }
        else
            Console.WriteLine("Ошибка ввода!");
    }
    else
    {
        if (a / 10000 > 0 && a / 10000 < 10)
        {
            if (a / 10000 == a % 10 && (a / 1000) % 10 == (a % 100) / 10)
                Console.WriteLine($"{a} -> да");
            else
                Console.WriteLine($"{a} -> нет");
        }
        else
            Console.WriteLine("Ошибка ввода!");
    }
}

Console.Clear();

int a = 0;

PalindromOrNo(a);