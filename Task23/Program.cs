// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


static void PrintSquares(int N)
{
    for (int i = 1; i < N; i++ )
    {
        Console.Write($"{i*i*i}, "); 
    }
    Console.WriteLine($"{N*N*N}");
}

Console.Clear();

int N;
while (true)
{
    Console.Write("Введите N: ");
    if (int.TryParse(Console.ReadLine(), out N))
        break;
    else
        Console.WriteLine("Ошибка ввода!");
}

Console.Write($"{N} -> ");
PrintSquares(N);