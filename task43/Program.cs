// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

(double, double) GetValue(int num)
{
    Console.WriteLine($"Введите значения для {num} прямой: ");
    (double b, double k) func;
    Console.Write($"b{num} = ");
    func.b = Convert.ToInt32(Console.ReadLine());
    Console.Write($"k{num} = ");
    func.k = Convert.ToInt32(Console.ReadLine());
    return func;
}

void Calculation((double b, double k) first, (double b, double k) second)
{
    if ((first.k == second.k) && ((first.b == second.b)))
        DetectException(1);
    else if (first.k == second.k)
        DetectException(2);
    double x = (-second.b + first.b) / (-first.k + second.k);
    double y = second.k * x + second.b;
    PrintValue(first, second);
    PrintResult(x, y);
}

void PrintValue((double b, double k) first, (double b, double k) second)
{
    Console.Write($"b1 = {first.b}, k1 = {first.k}, ");
    Console.Write($"b2 = {second.b}, k2 = {second.k} ");
}

void PrintResult(double x, double y)
{
    Console.WriteLine($"-> ({x}; {y})");
}

void DetectException(int code)
{
    if (code == 1)
        Console.WriteLine("Прямые совпадают");
    else
        Console.WriteLine("Прямые параллельны");
    Environment.Exit(0);
}

(double, double) firstLine = GetValue(1);
(double, double) secondLine = GetValue(2);
Calculation(firstLine, secondLine);