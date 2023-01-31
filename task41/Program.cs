// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] GetArr(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    int[] arr = new int[num];
    for (int index = 0; index < num; index++)
    {
        Console.Write($"[{index + 1}]: ");
        arr[index] = int.Parse(Console.ReadLine());
    }
    return arr;
}

int SummPlus(int[] arr)
{
    int summ = 0;
    for (int index = 0; index < arr.Length; index++)
        if (arr[index] > 0)
            summ++;
    return summ;
}

void PrintResult(int[] arr, int num)
{
    for (int index = 0; index < arr.Length - 1; index++)
        Console.Write($"{arr[index]}, ");
    Console.Write($"{arr[arr.Length - 1]} -> {num}");
}

int[] array = GetArr("Сколько чисел вы хотите ввести? ");
int plusNumbers = SummPlus(array);
PrintResult(array, plusNumbers);