// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

using ProgramClass;

int numberA = UserInput.GetInputNumber("Введите число A: ");
int numberB = UserInput.GetInputNumber("Введите число B: ");

int resultAckermanFunction = ActionsWithNumbers.AckermanFunction(numberA, numberB);
Console.WriteLine(resultAckermanFunction);