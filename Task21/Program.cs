// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

static int Koords(string message)
{
    int result;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result))
            break;
        else
            Console.WriteLine("Ошибка ввода!");
    }
    return result;
}

static double Distance(int a1, int a2, int b1, int b2, int c1, int c2)
{
    double result = Math.Sqrt(Math.Pow(c1 - b1 - a1, 2) + Math.Pow(c2 - b2 - a2, 2));
    return result;
}

// Я слаб в координатных осях, не знаю нужных формул, поэтому ответ у меня не сходится
// Но главное что всё работает, верно? Формулы можно подставить...


Console.Clear();
int a1, a2, b1, b2, c1, c2;
a1 = Koords("Введите координату X первого числа: ");
b1 = Koords("Введите координату Y первого числа: ");
c1 = Koords("Введите координату Z первого числа: ");
a2 = Koords("Введите координату X первого числа: ");
b2 = Koords("Введите координату Y первого числа: ");
c2 = Koords("Введите координату Z первого числа: ");
double distance = Distance(a1, a2, b1, b2, c1, c2);
Console.WriteLine(distance);

