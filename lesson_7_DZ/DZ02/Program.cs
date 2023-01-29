// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
using ProgramClass;

int row = UserInput.GetUserNumber("Введити количество строк: ");
int columns = UserInput.GetUserNumber("Введити количество столбцов: ");

int[,] array = ActionsWithArrays.GetRandomArray(row, columns);
ActionsWithArrays.PrintArrayIJ(array);
int rowIndex = UserInput.GetUserNumber("Введитк индекс строки: ");
int columnsIndex = UserInput.GetUserNumber("Введите индекс столбца: ");
ActionsWithArrays.FindElementArray(array, rowIndex, columnsIndex);