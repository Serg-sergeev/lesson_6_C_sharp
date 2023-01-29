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


void ReplacingRows(int[,] array, int firstRow, int secondRow)
{

    int[] tempArray1 = new int[array.GetLength(1)];
    int[] tempArray2 = new int[array.GetLength(1)];


    for (int j = 0; j < array.GetLength(0); j++)
    {
        tempArray1[j] = array[firstRow - 1, j];
        tempArray2[j] = array[secondRow - 1, j];
    }

    for (int j = 0; j < array.GetLength(0); j++)
    {
        array[secondRow - 1, j] = tempArray1[j];
        array[firstRow - 1, j] = tempArray2[j];
    }

}

int row = GetUserInput("Введите количество строк: ");
int columns = GetUserInput("Введите количество столбцов: ");
int minValue = GetUserInput("Введите минимальное значение для генерации: ");
int maxValue = GetUserInput("Введите максимальное значение для генерации: ");

int[,] array = CreateArray(row, columns, minValue, maxValue);
PrintArray(array);
ReplacingRows(array, 1, 2);
Console.WriteLine();
PrintArray(array);

