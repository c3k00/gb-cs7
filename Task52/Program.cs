// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetArray2d()
{
    int m = Prompt("Введите значение m");
    int n = Prompt("Введите значение n");
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray2d(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array2d = GetArray2d();
PrintArray2d(array2d);





Console.WriteLine("---------------------------");
Console.Write("Среднее арифметическое каждого столбца:");
// Console.WriteLine(array2d.GetLength(0));
for (int j = 0; j < array2d.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        sum += array2d[i, j];
    }
    Console.Write($"{ sum / array2d.GetLength(0)}:");
}
// Console.ReadLine();