// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

using ProgramClass;

int rowOne = UserInput.GetInputNumber("Введите количество строк в первой матрице: ");
int columnsOne = UserInput.GetInputNumber("Введите количество столбцов в первой матрице: ");
int rowTwo = UserInput.GetInputNumber("Введите количество строк во второй матрице: ");
int columnsTwo = UserInput.GetInputNumber("Введите количество столбцов во второй матрице: ");

Console.WriteLine("Сгенерирована первая матрица: ");
int[,] arrayOne = ActionsWithArray.GetRandom(rowOne, columnsOne); 
ActionsWithArray.Print(arrayOne);
Console.WriteLine();

Console.WriteLine("Сгенерирована вторая матрица: ");
int[,] arrayTwo = ActionsWithArray.GetRandom(rowTwo, columnsTwo); 
ActionsWithArray.Print(arrayTwo);
Console.WriteLine();

Console.WriteLine("Результат умножения матриц: ");
int[,] array = ActionsWithArray.GetCompositionMatrix(arrayOne, arrayTwo);
ActionsWithArray.Print(array);