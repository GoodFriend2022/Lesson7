// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int Prompt(string message)// Запрашивает целое число на ввод
{
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,] array)// Заполняет двумерный массив с целыми числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-99, 100);
        }
    }
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

void FindElementToArray(int[,] array, int findRow, 
    int findColumn)// Возвращает элемент с заданными индексами в массиве
{
    if (findRow > array.GetLength(0) || findRow < 1 
        || findColumn > array.GetLength(1) || findColumn < 1)
    {
        Console.WriteLine("Такого элемента не существует");
    }
    else
    {
        int findElement = array[findRow - 1, findColumn - 1];
        Console.WriteLine($"Позицию ({findRow}, {findColumn}) имеет элемент > {findElement}");
    }
}

int[,] numbers = new int[4, 5];
FillArray(numbers);
PrintArray(numbers);
int userFindRow = Prompt("Введите искомый индекс строки");
int userFindColumn = Prompt("Введите искомый индекс столбца");
FindElementToArray(numbers, userFindRow, userFindColumn);
