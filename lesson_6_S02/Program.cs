
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

bool IsTriangle(int numberA, int numberB, int numberC)
{
    if (numberA + numberB > numberC
    &&  numberB + numberC > numberA
    &&  numberA + numberC > numberB)
    return true;
    else return false;
}

int numberA = GetUserInput();
int numberB = GetUserInput();
int numberC = GetUserInput();

if (IsTriangle(numberA, numberB, numberC)) Console.WriteLine("Да, существует");
else Console.WriteLine("Нет, не существует");

