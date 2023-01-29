// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
using ProgramClass;

int k1 = UserInput.GetUserInput("Введите коэфициент первого уравнения: ");
int b1 = UserInput.GetUserInput("Введите второй коэфициент первого уравнения: ");
int k2 = UserInput.GetUserInput("Введите коэфициент второго уравнения: ");
int b2 = UserInput.GetUserInput("Введите второй коэфициент второго уравнения: ");

Console.WriteLine($"Точка пересечениея прямых: ({String.Join(", ", OperationEquations.GetIntersectionPoint(k1, k2, b1, b2))})");