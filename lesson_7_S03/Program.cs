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

int[,] CreateArray(int rows, int columns, int minValue = 0, int maxValue = 10)
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

int[,] GetModifyOddIndexArray(int[,] array)
{
    

    for (int i = 0; i < array.GetLength(0); i+=2)
    {
        for (int j = 0; j < array.GetLength(1); j+=2)
        {
            array[i, j] *= array[i, j];
        }
    }

    return array;
}


int rows = GetUserInput("Введите количество строк: ");

int columns = GetUserInput("Введите количество столбцов: ");

int[,] array = CreateArray(rows, columns);
PrintArray(array);
array = GetModifyOddIndexArray(array);
Console.WriteLine();
PrintArray(array);