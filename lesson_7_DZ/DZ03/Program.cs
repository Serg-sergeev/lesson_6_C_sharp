// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

using ProgramClass;

int row = UserInput.GetUserNumber("Введити количество строк: ");
int columns = UserInput.GetUserNumber("Введити количество столбцов: ");

int[,] array = ActionsWithArrays.GetRandomArray(row, columns);
ActionsWithArrays.PrintArrayIJ(array);

double[] arithmeticMeanArray = ActionsWithArrays.GetArithmeticMeanCulumnsArray(array);
Console.WriteLine("Среднее арифметическое значение по столбцам: " + String.Join(" ", arithmeticMeanArray));