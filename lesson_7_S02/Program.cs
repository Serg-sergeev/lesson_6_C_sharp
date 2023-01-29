//Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: 
//Aₘₙ = m+n. Выведите полученный массив на экран.
//m = 3, n = 4.

int[,] CreateArrayIJ(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }

        Console.WriteLine();
    }
}

int GetUserInput(string text)
{
    int userInput;
    string? input;

    do
    {
        Console.Write(text);
        input = Console.ReadLine();
    }
    while (!int.TryParse(input, out userInput));

    return userInput;
}

int rows = GetUserInput("Введите количество строк: ");

int columns = GetUserInput("Введите количество столбцов: ");

PrintArray(CreateArrayIJ(rows, columns));