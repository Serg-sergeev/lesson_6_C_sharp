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

int[,] CreateArray(int rows, int columns, int minValue = 0, int maxValue = 3)
{
    int[,] array = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }

    return array;
}

int GetSumElementsMainDiagonal(int[,] array)
{
    int sum =0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, i];
    }

    return sum;
}

int GetSumElementsSecondaryDiagonal(int[,] array)
{
    int sum =0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[array.GetLength(0) - i - 1, i];
    }

    return sum;
}


int rows = GetUserInput("Введите количество строк: ");

int columns = GetUserInput("Введите количество столбцов: ");

int[,] array = CreateArray(rows, columns);
PrintArray(array);
Console.WriteLine("Сумма элементов главной диагонали");
Console.WriteLine(GetSumElementsMainDiagonal(array));
Console.WriteLine("Сумма элементов побочной диагонали");
Console.WriteLine(GetSumElementsSecondaryDiagonal(array));