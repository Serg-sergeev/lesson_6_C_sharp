// Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

using ProgramClass;

int numberM = UserInput.GetInputNumber("Введите число M: ");
int numberN = UserInput.GetInputNumber("Введите число N: ");

int sumNaturalnumbers = ActionsWithNumbers.GetSumNaturalNumbersMtoN(numberM, numberN);
Console.WriteLine(sumNaturalnumbers);
