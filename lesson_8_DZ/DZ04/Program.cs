// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

using ProgramClass;

int row = UserInput.GetInputNumber("Введите количество строк в массиве: ");
int columns = UserInput.GetInputNumber("Введите количество столбцов в массиве: ");
int count = UserInput.GetInputNumber("Введите количество таблиц в массиве: ");

int[,,] array = ActionsWithArray.GetRandom(count, columns, row);
ActionsWithArray.Print(array);

ActionsWithArray.GetIndexElementsArray(array);