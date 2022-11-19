// Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int Prompt(string message)// Запрашивает целое число на ввод
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

double[,] CreateArray(int rows, int columns)// Создает двумерный массив с вещественными числами
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(-99, 100) + new Random().NextDouble();
        }
    }
    return array;
}

void PrintArray(double[,] array)// Возвращает дмумерный массив с вещественными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]:f2}\t");
        }
        System.Console.WriteLine();
    }
}

int amountRows = Prompt("Введите количество строк в массиве");
int amountColumns = Prompt("Введите количество столбцов в массиве");
double[,] numbers = CreateArray(amountRows, amountColumns);
PrintArray(numbers);

