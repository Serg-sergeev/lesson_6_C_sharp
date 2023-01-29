// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
using ProgramClass;

int row = UserInput.GetUserInput();
int columns = UserInput.GetUserInput();
double[,] array = ActionsWithArrays.GetRandomTwoDimensionalArray(row, columns);
ActionsWithArrays.PrintArray(array);
