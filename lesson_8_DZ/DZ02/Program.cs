// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

using ProgramClass;

int row = UserInput.GetUserNumber("Введити количество строк: ");
int columns = UserInput.GetUserNumber("Введити количество столбцов: ");

int[,] array = ActionsWithArrays.GetRandomArray(row, columns);
ActionsWithArrays.PrintArrayIJ(array);

Console.WriteLine();
Console.WriteLine($"Строка с минимальной суммой элементов: {ActionsWithArrays.GetRowSmallestSumElements(array)}");

