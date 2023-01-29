// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

using ProgramClass;

int row = UserInput.GetUserNumber("Введити количество строк: ");
int columns = UserInput.GetUserNumber("Введити количество столбцов: ");

int[,] array = ActionsWithArrays.GetRandomArray(row, columns);
ActionsWithArrays.PrintArrayIJ(array);