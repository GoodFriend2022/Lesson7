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

void PrintArray(int[,] array)// Возвращает дмумерный массив с вещественными числами
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

void EverageToColumns(int[,] array)// Возвращает среднее арифметическое в каждом столбце
{
    System.Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        System.Console.Write($"{(sum / array.GetLength(0)):f2} ");
    }
}

int amountRows = Prompt("Введите количество строк в массиве");
int amountColumns = Prompt("Введите количество столбцов в массиве");
int[,] numbers = CreateArray(amountRows, amountColumns);
PrintArray(numbers);
EverageToColumns(numbers);

