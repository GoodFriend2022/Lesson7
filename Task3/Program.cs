// Задача 3. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int Prompt(string message)// Запрашивает целое число на ввод
{
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateArray(int rows, int columns)// Создает двумерный массив с целыми числами
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)// Возвращает дмумерный массив с вещественными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void PrintArray(double[] array)// Возвращает одномерный массив
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]:f2} ");
    }
}

double[] EverageToColumns(int[,] array)// Возвращает среднее арифметическое в каждом столбце
{
    double[] everage = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        everage[i] = sum / array.GetLength(0);
    }
    return everage;
}

int amountRows = Prompt("Введите количество строк в массиве");
int amountColumns = Prompt("Введите количество столбцов в массиве");
int[,] numbers = CreateArray(amountRows, amountColumns);
PrintMatrix(numbers);
PrintArray(EverageToColumns(numbers));

