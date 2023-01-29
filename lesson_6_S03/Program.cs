int GetUserInput()
{
    int userInput;
    string? input;

    do
    {
        Console.Write("Введите число: ");
        input = Console.ReadLine();
    }
    while (!int.TryParse(input, out userInput));

    return userInput;
}

int[] ToBinaryCode(int number)
{
    int[] array = new int[16];
    while (number != 0)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int remeins = number % 2;
            array[i] = remeins;
            number = number / 2;
        }

        for (int i = 0; i < array.Length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[array.Length - 1 - i];
            array[array.Length - 1 - i] = temp;
        }
    }
    return array;
}


int number = GetUserInput();
Console.WriteLine(string.Join(" ", ToBinaryCode(number)));